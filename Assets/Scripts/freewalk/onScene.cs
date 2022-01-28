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
        reverseAll();

        /*if ((mode % 3) == 0)
        {
            reverseLeftAndRight();
        }
        else if ((mode % 3) == 1)
        {
            reverseFrontAndBack();
        }
        else
        {
            reverseAll();
        }*/
    }


    void reverseFrontAndBack()
    {
        Vector3 p = vrCamera.position;
        p.x *= -1f * scale + offset.x;
        p.y = offset.y;
        p.z *= 2f * scale + offset.z;
        transform.position = p;
    }

    void reverseLeftAndRight()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale + offset.x;
        p.y = offset.y;
        p.z *= -1f * scale + offset.z;
        transform.position = p;
    }


    void reverseAll()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale + offset.x;
        p.y = offset.y;
        p.z *= 2f * scale + offset.z;
        transform.position = p;

        //print("vr:" + vrCamera.position);
        //print("scene:" + transform.position);
    }

    void reverseRotation()
    {

    }


}
