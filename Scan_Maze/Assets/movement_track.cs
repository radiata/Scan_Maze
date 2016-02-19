using UnityEngine;
using System.Collections;

public class movement_track : MonoBehaviour {

    private static bool Right = false, Left = false, Stop = false, Flip = false;

	
	// Update is called once per frame
	void Update () {

        if(Stop == false)
        {
            transform.Translate(0, 0, (float).05);
        }
        
        if (Right == true)
        {
            transform.Rotate(0, 90, 0);
            Right = false;
            Stop = false;
        }

        if (Left == true)
        {
            transform.Rotate(0, -90, 0);
            Left = false;
            Stop = false;
        }

        if(Flip == true)
        {
            transform.Rotate(0, 180, 0);
        }
    }

    public static void TurnLeft()
    {
        Left = true;
    }

    public static void TurnRight()
    {
        Right = true;
    }

    public static void StopMovement()
    {
        Stop = true;
    }

    public static void Go()
    {
        Stop = false;
    }

    public static void flip()
    {
        Flip = true;
    }

}
