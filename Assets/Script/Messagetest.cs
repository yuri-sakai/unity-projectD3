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
        
    }
}
