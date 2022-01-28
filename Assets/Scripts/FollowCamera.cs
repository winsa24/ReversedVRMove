using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform vrCamera;

    private float initialHeight;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = vrCamera.position;
        transform.rotation = vrCamera.rotation;

        initialHeight = vrCamera.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = vrCamera.position;
        transform.rotation = vrCamera.rotation;

    }
}
