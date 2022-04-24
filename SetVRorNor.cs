using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVRorNor : MonoBehaviour
{
    public GameObject XROrigin;
    public GameObject Player;
    private bool isOnXRDevice = false;
    // Start is called before the first frame update

    private void Awake()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            isOnXRDevice = true;
        }
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            isOnXRDevice = false;
        }

        XROrigin.SetActive(isOnXRDevice);
        Player.SetActive(!isOnXRDevice);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
