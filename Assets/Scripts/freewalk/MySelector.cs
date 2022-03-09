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
    private int worldFlag = 0;


    public int mode = 0;
    public int attemp = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.Button.One, controllerR))
        {
            worldFlag++;
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
            attemp++;
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

        modeText.text += "\nStart attemp " + attemp;


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
        if (worldFlag%3 == 0)
        {
            modeText.text += "\nReal world before VR";
        }
        else if(worldFlag%3 ==1)
        {
            modeText.text += "\nVR world";
        }
        else
        {
            modeText.text += "\nReal world after VR";
        }

    }


}
