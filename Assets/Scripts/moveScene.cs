using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScene : MonoBehaviour
{
    public Transform vrCamera;
    public float scale = 1f;

    private Vector3 offset = new Vector3(0.1f, -0.5f, -1f);

    // Start is called before the first frame update
    void Start()
    {
        //vrCamera.position = new Vector3(0, 5, -15);
        transform.position = vrCamera.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale + offset.x;
        p.y = offset.y;
        p.z *= 2f * scale + offset.z;

        // bird view reverse
        //p.x *= -1f;
        //p.y = -5f;
        //p.z += 15f;  
        transform.position = p;
        print("vr:" + vrCamera.position);
        print("scene:" + transform.position);


        Quaternion q = vrCamera.rotation;
        //q.y *= -1f;
        q.y = 0;
        q.x = 0;
        q.z = 0;
        transform.rotation = q;
        print("scene rotation:" + transform.rotation);
        //transform.rotation = Quaternion.Inverse(vrCamera.rotation);

       
    }

    
}
