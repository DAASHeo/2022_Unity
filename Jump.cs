using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    private Rigidbody rigid;

    private bool IsJumping;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        IsJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate((new Vector3(h, 0, v) * 10) * Time.deltaTime);
    }

    void Jump ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!IsJumping)
            {
                IsJumping = true;
                rigid.AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
            }
        }

        else
        {
            return;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Land"))
        {
            IsJumping = false;
        }
    }
}