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
    public GameObject track2;
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
        if (col.gameObject.name == "offTrack"){
            Debug.Log("enter offTrack");

            var cubeRenderer = track.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
            var cubeRenderer2 = track2.GetComponent<Renderer>();
            cubeRenderer2.material.SetColor("_Color", Color.red);
            return;
        }
        else if (col.gameObject.name == "Track")
        {

            Debug.Log("enter track");

            var cubeRenderer = track.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.green);
            var cubeRenderer2 = track2.GetComponent<Renderer>();
            cubeRenderer2.material.SetColor("_Color", Color.green);
            return;
        }else{
          Debug.Log("enter floor");

          var cubeRenderer = track.GetComponent<Renderer>();
          cubeRenderer.material.SetColor("_Color", Color.red);
          var cubeRenderer2 = track2.GetComponent<Renderer>();
          cubeRenderer2.material.SetColor("_Color", Color.red);
        }

    }

    private void OnTriggerStay(Collider col)
    {




    }

    private void OnTriggerExit(Collider col)
    {
      if (col.gameObject.name == "offTrack"){
          Debug.Log("exit offTrack");

          var cubeRenderer = track.GetComponent<Renderer>();
          cubeRenderer.material.SetColor("_Color", Color.green);
          var cubeRenderer2 = track2.GetComponent<Renderer>();
          cubeRenderer2.material.SetColor("_Color", Color.green);
          return;
      }else if (col.gameObject.name == "Track")
      {

          Debug.Log("exit track");

          var cubeRenderer = track.GetComponent<Renderer>();
          cubeRenderer.material.SetColor("_Color", Color.red);
          var cubeRenderer2 = track2.GetComponent<Renderer>();
          cubeRenderer2.material.SetColor("_Color", Color.red);
          return;
      }


    }
}
