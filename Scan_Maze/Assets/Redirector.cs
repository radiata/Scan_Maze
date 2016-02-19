using UnityEngine;
using System.Collections;

public class Redirector : MonoBehaviour {

    private bool resolved = false;
    void OnTriggerEnter()
    {

        if(Input_Recorder.getKey() == KeyCode.A)
        {
            movement_track.TurnLeft();
            resolved = true;
        }
        if(Input_Recorder.getKey() == KeyCode.D)
        {
            movement_track.TurnRight();
            resolved = true;
        }
        if(Input_Recorder.getKey() == KeyCode.None)
        {
            movement_track.StopMovement();
        }

    }

    void OnTriggerStay()
    {
        if(resolved != true)
        {
            if (Input_Recorder.getKey() == KeyCode.A)
            {
                movement_track.TurnLeft();
                resolved = true;
            }
            if (Input_Recorder.getKey() == KeyCode.D)
            {
                movement_track.TurnRight();
                resolved = true;
            }
            if (Input_Recorder.getKey() == KeyCode.W)
            {
                movement_track.Go();
                resolved = true;
            }
        }
    }

    void OnTriggerExit()
    {
        Input_Recorder.resetKey();
    }
}
