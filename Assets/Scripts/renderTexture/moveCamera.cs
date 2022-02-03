using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public Transform vrCamera;
    public TextMeshPro modeText;
    public GameObject Lcontroller;
    private float triggerValue;
    // public variable that can be set to LTouch or RTouch in the Unity Inspector

    private int mode;
    private float initialHeight;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = vrCamera.position;
        //transform.rotation = vrCamera.rotation;

    }

    // Update is called once per frame
    void Update()
    {

        //mode = Lcontroller.GetComponent<MySelector>().mode;
     
        if (mode % 2 == 0)
        {
            modeText.text = "reverse move";
            Vector3 p = vrCamera.position;
            p.x *= -1f;
            p.z *= transform.position.z;
            p.y = transform.position.y;
            transform.position = p;

            //transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.rotation = vrCamera.rotation;
        }
        else
        {
            modeText.text = "reverse rotate";
            reverseRotation();
        }


    }

    void selectMode(float triggerValue)
    {
        // returns a float of the Hand Trigger’s current state on the Oculus Touch controller
        // specified by the controller variable.
        if(triggerValue > 0.95f)
        {
            mode++;
            modeText.text = "mode: " + mode.ToString();
        }
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
