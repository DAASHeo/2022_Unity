using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddg02 : MonoBehaviour
{
    public float xPos, yPos, zPos;
    public float yPlus;
    // Start is called before the first frame update
    void Start()
    {
        xPos = 3.5f;
        yPos = -2.0f;
        zPos = 2.0f;
        yPlus = Random.Range(0.005f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        if (yPos > 2 || yPos < -2)
        {
            yPlus = yPlus * -1;
        }
        yPos = yPos + yPlus;
        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
