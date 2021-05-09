using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messagetest : MonoBehaviour

{   Text Debugtext;
    // Start is called before the first frame update
    void Start()
    {  
        Debugtext = GetComponentInChildren<Text>();
        Debugtext.text = "DebugLog";

        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debugtext.text = "Abuttonをおした";
        }
        Vector3 RtouchV3  = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        Vector3 LtouchV3  = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        Debugtext.text = "Debug"+"RtouchV3:"+ RtouchV3+"LtouchV3:"+LtouchV3;
        Debugtext.text = Vector3.SignedAngle(LtouchV3, RtouchV3,new Vector3(1, 1, 1)).ToString();
        
        
    }
}
