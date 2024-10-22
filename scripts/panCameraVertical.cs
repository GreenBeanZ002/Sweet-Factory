using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class panCameraVertical : MonoBehaviour
{
    public Camera camera; 
    // Update is called once per frame
    void Update()
    {
        //allows movement of camera by user
        if (Input.GetKey(KeyCode.UpArrow))
        {
            camera.transform.Translate(0, -0.1f * 50 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            camera.transform.Translate(0, 0.1f * 50 * Time.deltaTime, 0);
        }
    }
}
