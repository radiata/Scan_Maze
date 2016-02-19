using UnityEngine;
using System.Collections;

public class Activator : MonoBehaviour {

    void OnTriggerEnter()
    {
        Input_Recorder.actvate();
        Debug.Log("activated");
    }
}
