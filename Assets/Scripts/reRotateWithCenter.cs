using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class reRotateWithCenter : MonoBehaviour
{
    public GameObject target;

    public TextMeshPro position;
    public TextMeshPro rotation;


    private OVRInput.Controller controller;
    private float triggerValue;
    // Use this for initialization

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

        position.text = "camera: " + target.transform.position.ToString();
        rotation.text = "me: " + transform.position.ToString();

        transform.localRotation = Quaternion.Inverse(target.transform.localRotation);
        //transform.position = transform.InverseTransformPoint(target.transform.position);
    }
}
