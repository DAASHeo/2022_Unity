using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin2 : MonoBehaviour
{
    bool checking;
    // Start is called before the first frame update
    void Start()
    {
        checking = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if(transform.eulerAngles.z > 30 || transform.eulerAngles.z < -30 || transform.eulerAngles.x > 30 || transform.eulerAngles.x < -30)
        //{
        //    counter = counter + 1;
        //    Debug.Log("Drop");
        //}

    }
    private void OnCollisionEnter(Collision other)
    {
        if (checking == true)
        {
            if (other.transform.tag == "ball")
            {
                if (transform.eulerAngles.z > 50 || transform.eulerAngles.z < -50 || transform.eulerAngles.x > 50 || transform.eulerAngles.x < -50)
                {
                    pins.counter = pins.counter + 1;
                    Debug.Log("pin2 out");
                    //Debug.Log(transform.eulerAngles);
                    checking = false;
                }
                else
                {
                    return;
                }
            }
            else if (other.transform.tag == "plane")
            {
                pins.counter = pins.counter + 1;
                Debug.Log("pin2 out");
                checking = false;
            }
        }
    }
}
