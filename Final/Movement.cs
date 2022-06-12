using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sensitivity = 500f; //감도 설정
    float rotationX = 0.0f;  //x축 회전값
    float rotationY = 0.0f;  //z축 회전값

    void Update()
    {
        MouseSencer();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(movement / 2);
    }
    void MouseSencer()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        rotationX += x * sensitivity * Time.deltaTime;
        rotationY += y * sensitivity * Time.deltaTime;

        if (rotationY > 30)
        {
            rotationY = 30;
        }
        else if (rotationY < -30)
        {
            rotationY = -30;
        }
        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
    }


}


//void Update()
//{
//    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

//    transform.Translate(movement / 2);
//}