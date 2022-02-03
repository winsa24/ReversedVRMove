using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MySelector : MonoBehaviour
{
    public TextMeshProUGUI modeText;
    public OVRInput.Controller controller;
    public GameObject track;
    private bool trackFlag = true;


    private float indextriggerValue;
    private float handtriggerValue;



    public int mode = 0;

    // Start is called before the first frame update
    void Start()
    {
        print("123");
    }

    // Update is called once per frame
    void Update()
    {
        indextriggerValue = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger, controller);
        
        if (indextriggerValue > 0.7)
        {
            print("push");
            mode++;
            // modeText.text = "click: " + (mode % 3).ToString();
            showInfo();
        }

        handtriggerValue = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger, controller);
        if (handtriggerValue < 0.95f)
        {
            print("hand release");
        }
        //select
        else if (handtriggerValue > 0.95)
        {
            print("hand push");
            trackFlag = !trackFlag;
            showInfo();

        }

        
    }

    void showInfo()
    {
        //show reverse info
        if ((mode % 3) == 0)
        {
            modeText.text = "reverse left and right";
        }
        else if ((mode % 3) == 1)
        {
            modeText.text = "reverse front and back";
        }
        else
        {
            modeText.text = "reverse all";
        }

        // show track info
        if (trackFlag)
        {
            modeText.text += "\n enable track";
            track.SetActive(true); // false to hide, true to show
        }
        else
        {
            modeText.text += "\n disable track";
            track.SetActive(false); // false to hide, true to show
        }
    }


}
