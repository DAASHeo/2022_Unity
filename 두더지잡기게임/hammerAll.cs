using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerAll : MonoBehaviour
{
    public int rotX, rotP;
    bool hammering = false; //망치로 내려치지 않음
    // Start is called before the first frame update
    void Start()
    {
        rotX = -90; //-90도로 회전된 것이 기본(서있는상황), 회전 힘은 1
        rotP = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 좌클릭하면
        {
            hammering = true; // 망치로 내려친다.
        }
        //망치로 내려칠때
        if (hammering == true)
        {

            if (Input.mousePosition.x < Screen.width / 3 && Input.mousePosition.y > Screen.height / 2)
            {
                transform.position = new Vector3(-1, 2, -9);
            }

            if (Input.mousePosition.x > Screen.width / 3 && Input.mousePosition.x < Screen.width * 2 / 3 && Input.mousePosition.y > Screen.height / 2)
            {

                transform.position = new Vector3(3, 2, -8);
            }

            if (Input.mousePosition.x > Screen.width * 2 / 3 && Input.mousePosition.x < Screen.width && Input.mousePosition.y > Screen.height / 2)
            {
                transform.position = new Vector3(6, 2, -9);
            }

            if (Input.mousePosition.x < Screen.width / 3 && Input.mousePosition.y < Screen.height / 2)
            {
                transform.position = new Vector3(-1, 2, -13);
            }

            if (Input.mousePosition.x > Screen.width / 3 && Input.mousePosition.x < Screen.width * 2 / 3 && Input.mousePosition.y < Screen.height / 2)
            {

                transform.position = new Vector3(2, 2, -14);
            }

            if (Input.mousePosition.x > Screen.width * 2 / 3 && Input.mousePosition.x < Screen.width && Input.mousePosition.y < Screen.height / 2)
            {
                transform.position = new Vector3(6, 2, -13);
            }


            if (rotX > 0)
            {
                rotP = rotP * -1;
            }
            rotX = rotX + rotP;
            transform.rotation = Quaternion.Euler(rotX, 0, 0);
            if (rotX < -90)
            {
                hammering = false;
                rotX = -90;
                rotP = rotP * -1;
                transform.position = new Vector3(-3, 2, -8);
            }
        }
    }
}