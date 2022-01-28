using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Camera")
        {

            Debug.Log("collision");
            //Get the Renderer component from the new cube
            var cubeRenderer = GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.green);

        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "Camera")
        {
            Debug.Log("leavingtrigger");
            //Get the Renderer component from the new cube
            var cubeRenderer = GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.yellow);
        }
    }
}
