using UnityEngine;
using System.Collections;

public class Redirector : MonoBehaviour {

    void OnTriggerEnter()
    {

        if(Input_Recorder.getKey() == KeyCode.A)
        {
            movement_track.TurnLeft();
        }
        if(Input_Recorder.getKey() == KeyCode.D)
        {
            movement_track.TurnRight();
        }

    }

    void OnTriggerExit()
    {
        Input_Recorder.resetKey();
    }
}
