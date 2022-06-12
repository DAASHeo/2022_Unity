using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float xPos, yPos, zPos;
    public float xPlus;
    // Start is called before the first frame update
    void Start()
    {
        yPos = 0;
        xPlus = Random.Range(0.25f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(xPos > 12 || xPos< -12)
        {
            xPlus = xPlus * -1;
        }
        xPos = xPos + xPlus;
        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
