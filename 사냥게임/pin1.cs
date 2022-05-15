using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin1 : MonoBehaviour
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
        //if (checking == true)
        //    if (transform.eulerAngles.z > 30 || transform.eulerAngles.z < -30 || transform.eulerAngles.x > 30 || transform.eulerAngles.x < -30)
        //    {
        //        pins.counter = pins.counter + 1;
        //        Debug.Log("pin1 out");
        //        checking = false;
        //    }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (checking == true)
        {
            if (other.transform.tag == "ball")
            {
                if (transform.eulerAngles.z > 30 || transform.eulerAngles.z < -30 || transform.eulerAngles.x > 50 || transform.eulerAngles.x < -50)
                {
                    pins.counter = pins.counter + 1;
                    Debug.Log("pin1 out");
                    checking = false;
                }
            }
            else if (other.transform.tag == "plane")
            {
                pins.counter = pins.counter + 1;
                Debug.Log("pin1 out");
                checking = false;
            }
        } 
    }
}
