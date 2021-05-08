using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update(){
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Aボタンを押した");
            SceneManager.LoadScene("BulletTrain");
        }
    }
}
