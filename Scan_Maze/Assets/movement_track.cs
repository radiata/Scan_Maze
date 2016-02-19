using UnityEngine;
using System.Collections;

public class movement_track : MonoBehaviour {

    private static bool Right = false, Left = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, (float).05);

        if (Right == true)
        {
            transform.Translate(-90, 0, 0);
            Right = false;
        }
        if (Left == true)
        {
            transform.Translate(90, 0, 0);
            Left = false;
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

}
