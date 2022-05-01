using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text ScriptTxt;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("count");
    }

    // Update is called once per frame
    void Update()
    { 
            ScriptTxt.text = hammer.count.ToString();
    }
}
