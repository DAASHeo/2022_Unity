using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    public static int count; //점수가 들어갈 변수 설정
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ddg"))
        {
            count += 1;
            Debug.Log("두더지를 잡았습니다! s+ 1");
        }
    }
}
