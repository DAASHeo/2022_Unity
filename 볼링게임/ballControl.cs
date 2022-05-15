using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        if (Input.GetMouseButtonDown(0))
        {
            print("Grab!");
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Throw!");
            rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(0, 0, 50.0f, ForceMode.Impulse);
        }
    }

}