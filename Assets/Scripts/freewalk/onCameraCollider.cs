using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.IO;
using System.Text;

public class onCameraCollider : MonoBehaviour
{
    public TextMeshProUGUI roundInfo;
    private int count = 0;

    public GameObject track;

    // Start is called before the first frame update
    void Start()
    {

        //roundInfo.transform.position = new Vector3(1.1f, -0.2f, -2f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "offTrack")
        //{

        //    Debug.Log("off track");

        //    var cubeRenderer = track.GetComponent<Renderer>();

        //    //Call SetColor using the shader property name "_Color" and setting the color to red
        //    cubeRenderer.material.SetColor("_Color", Color.red);

        //    roundInfo.text += "off track : " + Time.time.ToString() + "\n";
        //    // change line
        //    Vector3 p = roundInfo.transform.position;
        //    p.y += 0.4f;
        //    roundInfo.transform.position = p;
        //}
        if (col.gameObject.name == "Track")
        {

            Debug.Log("on track");

            var cubeRenderer = track.GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.green);

            roundInfo.text += "on the track : " + Time.time.ToString() + "\n";
            // change line
            Vector3 p = roundInfo.transform.position;
            p.y += 0.4f;
            roundInfo.transform.position = p;
        }
        else
        {
            Debug.Log("off track");

            var cubeRenderer = track.GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.red);

            roundInfo.text += "off track : " + Time.time.ToString() + "\n";
            // change line
            Vector3 p = roundInfo.transform.position;
            p.y += 0.4f;
            roundInfo.transform.position = p;
        }
        
       
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag != "Cube")
        {
            //Debug.Log("off track");

            //roundInfo.text += "off track\n";
            // change line
            //Vector3 p = roundInfo.transform.position;
            //p.y += 0.1f;
            //roundInfo.transform.position = p;
        }
    }
}
