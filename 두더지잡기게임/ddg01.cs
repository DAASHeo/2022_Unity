using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddg01 : MonoBehaviour
{
    public float xPos, yPos, zPos;
    public float yPlus;
    // Start is called before the first frame update
    void Start()
    {
        xPos = 0.0f;
        yPos = -1.0f;
        zPos = 3.0f;
        yPlus = Random.Range(0.005f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if(yPos > 2 || yPos < -2)
        {
            yPlus = yPlus * -1;
        }
        yPos = yPos + yPlus;
        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
