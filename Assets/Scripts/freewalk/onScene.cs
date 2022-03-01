using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onScene : MonoBehaviour
{
    public Transform vrCamera;
    public float scale = 1f;
    public GameObject controller;

    private int mode;
    private float height = 0.1f;

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
            transform.position = new Vector3(0, 0, 0);
            reverseAll();
        }
        else if ((mode % 4) == 1)
        {
            transform.position = new Vector3(0, 0, 0);
            reverseFrontAndBack();
        }
        else if ((mode % 4) == 2)
        {
            transform.position = new Vector3(0, 0, 0);
            reverseLeftAndRight();
        }
        else
        {
            transform.position = new Vector3(0, 0.1f, 0);
        }

    }


    void reverseFrontAndBack()
    {
        Vector3 p = vrCamera.position;
        p.z *= 2f * scale;
        p.y = height;
        p.x = 0;
        transform.position = p;
    }

    void reverseLeftAndRight()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale;
        p.y = height;
        p.z = 0;
        transform.position = p;
    }

    void reverseAll()
    {
        Vector3 p = vrCamera.position;
        p.x *= 2f * scale;
        p.z *= 2f * scale;
        p.y = height;
        transform.position = p;
    }


}
