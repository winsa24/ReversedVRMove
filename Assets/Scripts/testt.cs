using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class testt : MonoBehaviour
{
    public Transform vrCamera;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        print("vr:" + vrCamera.position);
        print("camera:" + transform.position);
        Vector3 p = vrCamera.position;
        p.x *= -2f;
        p.z = transform.position.z;
        p.y = transform.position.y;
        transform.position = p;

        //transform.rotation = new Quaternion(0, 0, 0, 0);
        //transform.rotation = vrCamera.rotation;

    }

    void reverseRotation()
    {
        transform.position = vrCamera.position;

        Quaternion p = vrCamera.rotation;
        //p.x *= -1f;
        //p.z *= -1f;
        //transform.rotation = p;
        transform.rotation = Quaternion.Inverse(vrCamera.rotation);
    }

    void reverseMove()
    {
        Vector3 p = vrCamera.position;
        p.x *= -1f;
        p.z *= -1f;
        transform.position = p;
    }
}
