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
            //rotX = 0;
            swordSwing = true;
        }
        if(swordSwing == true)
        {
            rotX = rotX + rotPx;
            if(rotX <= 0)
            {
                rotPx = rotPx * -1;
            }
            transform.rotation = Quaternion.Euler(rotX, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //rotX = 0;
            swordSwing = false;
        }
        if (swordSwing == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
