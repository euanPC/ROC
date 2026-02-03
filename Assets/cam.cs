using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject me ;
    public GameObject camera1;
    public GameObject compass;
    public int RotationSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform cam = camera1.transform;
        Transform Rotation = me.transform;
        float zrotation = Rotation.eulerAngles.y;
        //print(zrotation);
        Vector3 c = new Vector3(0, zrotation,0);
        cam.eulerAngles = c;
        //.localRotation = Quaternion.Euler(0,0,zrotation);
        float rotationinput = Input.GetAxis("Horizontal");
        gameObject.transform.Rotate(0, 0, rotationinput*RotationSpeed*Time.deltaTime);
        Vector3 compasss = new Vector3(-1*zrotation-90, 0, 0);
        compass.transform.eulerAngles = compasss;
    }
}
