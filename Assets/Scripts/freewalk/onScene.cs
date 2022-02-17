using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onScene : MonoBehaviour
{
    public Transform vrCamera;
    public float scale = 1f;
    public GameObject controller;

    private Vector3 offset = new Vector3(0.1f, 0f, -1f);

    private int mode;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = vrCamera.position;
    }

    // Update is called once per frame
    void Update()
    {
        mode = controller.GetComponent<MySelector>().mode;
        print("======>" + mode);

        //show reverse info
        if ((mode % 4) == 0)
        {
            reverseAll();
        }
        else if ((mode % 4) == 1)
        {
            reverseFrontAndBack();
        }
        else if ((mode % 4) == 2)
        {
            reverseLeftAndRight();
        }
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }

    }


    void reverseFrontAndBack()
    {
        Vector3 p = vrCamera.position;
        p.x = offset.x;
        p.y = offset.y;
        p.z *= 2f * scale;
        transform.position = p;
    }

    void reverseLeftAndRight()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale + offset.x;
        p.y = offset.y;
        p.z = offset.z;
        transform.position = p;
    }


    void reverseAll()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale;
        p.y = offset.y;
        p.z *= 2f * scale;
        transform.position = p;

        //transform.rotation = Quaternion.Euler(vrCamera.rotation.x * 2f, vrCamera.rotation.y * 2f, vrCamera.rotation.z * 2f);
        //print("vr:" + vrCamera.position);
        //print("scene:" + transform.position);
    }


}
