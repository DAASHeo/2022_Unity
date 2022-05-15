using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    bool swordSwing = false;
    int rotX, rotY, rotZ;
    int rotPx, rotPy, rotPz;
    // Start is called before the first frame update
    void Start()
    {
        rotX = 0;
        rotY = 0;
        rotZ = 0;
        rotPx = 1;
        rotPy = 1;
        rotPz = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            swordSwing = true;
            //print("0");
        }
        if(swordSwing == true)
        {
            if (rotX > 90)
            {
                rotPx = rotPx * -1;
            }
            rotX = rotX + rotPx;
            transform.localRotation = Quaternion.Euler(rotX, 0, 0);
            if (rotX <= 0)
            {
                swordSwing = false;
                rotX = 0;
                rotPx = rotPx * -1;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            //rotX = 0;
            //swordSwing = false;
        }
        //if (swordSwing == false)
        //{
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}

    }
}
