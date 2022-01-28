using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RoundControl : MonoBehaviour
{

    public TextMeshProUGUI roundInfo;

    // Start is called before the first frame update
    void Start()
    {
        roundInfo.text = "time: ";
        //roundInfo.transform.position = new Vector3(1.1f, -0.2f, -2f);
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


            roundInfo.text += Time.time.ToString() + "\n";
            Vector3 p = roundInfo.transform.position;
            p.y += 0.05f;
            roundInfo.transform.position = p;
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
