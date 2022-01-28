using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class onCamera : MonoBehaviour
{
    
    public TextMeshPro position;
    public TextMeshPro rotation;

    //private OVRInput.Controller controller;
    private float triggerValue;
    // Use this for initialization

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime);
        //transform.position = target.position * -1f;
        //transform.position = target.position;
        //transform.rotation = target.rotation;
        position.text = "position: " + transform.position.ToString();
        rotation.text = "rotation: " + transform.rotation.ToString();

        //transform.parent.localRotation = Quaternion.Inverse(transform.localRotation);
        transform.parent.Translate(transform.position * -1 * Time.deltaTime);
        //transform.parent.position = transform.InverseTransformPoint(transform.position);

        //triggerValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller);
        //if (triggerValue > 0.95f)
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime);
        //    text.text = "click";
        //    //transform.position = transform.posi
        //}
    }
}
