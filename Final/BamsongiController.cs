using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BamsongiController : MonoBehaviour
{
    public static int counter;
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "target")
        {
            counter = counter + 10;
            Destroy(gameObject);
            if (counter == 100)
            {
                SceneManager.LoadScene("Stage2");
            }
        }
        else { GetComponent<Rigidbody>().isKinematic = true; }
        
    }

    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000));
    }
}
