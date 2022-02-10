using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MySelector : MonoBehaviour
{
    public TextMeshProUGUI modeText;
    public OVRInput.Controller controllerR;
    public OVRInput.Controller controllerL;
    public GameObject track;
    private bool trackFlag = true;
    private bool worldFlag = true;


    public int mode = 0;
    public bool rotate = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.Button.One, controllerR))
        {
            worldFlag = !worldFlag;
            showInfo();
        }
        if (OVRInput.GetDown(OVRInput.Button.Two, controllerR))
        {
            trackFlag = !trackFlag;
            showInfo();
        }
        if (OVRInput.GetDown(OVRInput.Button.One, controllerL))
        {
            mode++;
            showInfo();
        }
        if (OVRInput.GetDown(OVRInput.Button.Two, controllerL))
        {
            rotate = !rotate;
            showInfo();
        }

    }


    void showInfo()
    {
        //show reverse info
        if ((mode % 4) == 0)
        {
            modeText.text = "reverse all";
        }
        else if ((mode % 4) == 1)
        {
            modeText.text = "reverse front and back";
        }
        else if ((mode % 4) == 2)
        {
            modeText.text = "reverse left and right";
        }
        else
        {
            modeText.text = "normal translate";
        }

        if (rotate)
        {
            modeText.text += "\nnormal rotate";
        }
        else
        {
            modeText.text += "\nreverse rotate";
        }

        // show track info
        if (trackFlag)
        {
            modeText.text += "\nEnable track";
            track.SetActive(true); // false to hide, true to show
        }
        else
        {
            modeText.text += "\nDisable track";
            track.SetActive(false); // false to hide, true to show
        }


        // show track info
        if (worldFlag)
        {
            modeText.text += "\nReal world";
        }
        else
        {
            modeText.text += "\nVR world";
        }

    }


}
