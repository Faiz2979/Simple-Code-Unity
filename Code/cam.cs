// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour{

    public float senX,senY;
    public Transform orientation;
    float xRotation,yRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible=false;
    }
    void Update()
    {
        // Mouse Input
    float MouseX=Input.GetAxisRaw("Mouse X")*Time.deltaTime*senX;
    float MouseY=Input.GetAxisRaw("Mouse Y")*Time.deltaTime*senY;
    yRotation +=MouseX;
    xRotation -=MouseY;
    xRotation=Mathf.Clamp(xRotation,-90f,90f);

    // Cam Rotation
    transform.rotation= Quaternion.Euler(xRotation,yRotation,0);
    orientation.rotation= Quaternion.Euler(0,yRotation,0);
    }
}