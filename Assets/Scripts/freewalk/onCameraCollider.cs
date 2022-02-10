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
    public Transform cameraPosition;

    public GameObject track;
    public GameObject track2;

    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        var cubeRenderer = track.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.yellow);
        var cubeRenderer2 = track2.GetComponent<Renderer>();
        cubeRenderer2.material.SetColor("_Color", Color.yellow);
        //roundInfo.transform.position = new Vector3(1.1f, -0.2f, -2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPosition.position;

        var cubeRenderer = track.GetComponent<Renderer>();
        var cubeRenderer2 = track2.GetComponent<Renderer>();
        if (flag)
        {

            cubeRenderer.material.SetColor("_Color", Color.green);
            cubeRenderer2.material.SetColor("_Color", Color.green);
        }
        else
        {
            cubeRenderer.material.SetColor("_Color", Color.red);
            cubeRenderer2.material.SetColor("_Color", Color.red);
        }
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "track")
        {
            flag = true;
            Debug.Log("enter track");

        }
        if (col.gameObject.name == "offTrack")
        {
            Debug.Log("enter offTrack");
            flag = false;
            return;
        }

    }

    private void OnTriggerStay(Collider col)
    {
        

        
    }

    private void OnTriggerExit(Collider col)
    {

        if (col.gameObject.name == "offTrack")
        {
            Debug.Log("exit offTrack");
            flag = true;
            return;
        }
        if (col.gameObject.tag == "track")
        {
            flag = false;
            Debug.Log("exit track");

        }
        
    }
}
