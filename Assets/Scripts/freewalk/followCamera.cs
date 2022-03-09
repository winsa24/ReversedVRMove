using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject controller;
    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 p = camera.transform.position;
        p.y = 0.05f;
        transform.position = p;

        transform.rotation = Quaternion.Euler(90f, 0, -camera.transform.eulerAngles.y);


    }
}
