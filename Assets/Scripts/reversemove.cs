using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class reversemove : MonoBehaviour
{
    public GameObject camera;
    public GameObject tracking;

    public Vector3 offset;

    public TextMeshPro position;
    public TextMeshPro rotation;

    // Start is called before the first frame update
    void Start()
    {
        camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        position.text = "camera: " + camera.transform.position.ToString();
        rotation.text = "tracking: " + tracking.transform.position.ToString();

        //transform.position = tracking.transform.InverseTransformPoint(tracking.transform.position);
        transform.position = tracking.transform.InverseTransformPoint(0, 0, 0);
        //transform.position = tracking.transform.position * -1;
        transform.rotation = tracking.transform.rotation;
    }
}
