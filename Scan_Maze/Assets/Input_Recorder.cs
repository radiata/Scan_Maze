using UnityEngine;
using System.Collections;

public class Input_Recorder : MonoBehaviour
{
    private static bool active = false;
    private static KeyCode input = KeyCode.None;
    public Texture UpBtn, LeftBtn, RightBtn;
    public bool UpHUD = false, LeftHUD = false, RightHUD = false;
    private bool inTrigger = false;
    private Rect UpBtnContainer = new Rect(140, 140, 0, 0),//(Screen.width/2 - (Screen.width / 40), Screen.height - 50, Screen.width/20, Screen.height/20),
                 LeftBtnContainer = new Rect(Screen.width/3, Screen.height - 50, Screen.width / 20, Screen.height / 20),
                 RightBtnContainer = new Rect(Screen.width - Screen.width / 3, Screen.height - 50, Screen.width / 20, Screen.height / 20);

    void OnTriggerEnter(Collider other)
    {
        if(active == true)
        {
            inTrigger = true;
            Debug.Log("entered");
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        Debug.Log("left");
    }

    void OnGui()
    {

        if (inTrigger == true & UpHUD == true)
        {
            GUI.Box(UpBtnContainer, UpBtn); 
        }
        if (inTrigger == true & LeftHUD == true)
        {
            GUI.Box(LeftBtnContainer, LeftBtn);
        }
        if (inTrigger == true & RightHUD == true)
        {
            GUI.Box(RightBtnContainer, RightBtn);
        }

    }

    public static void actvate()
    {
        active = true;
    }

    public static KeyCode getKey()
    {
        return input;
    }

    public static void resetKey()
    {
        input = KeyCode.None;
    }

    void Update()
    {
        if (inTrigger == true)
        {
            if(LeftHUD == true & Input.GetKeyDown("d"))
            {
                input = KeyCode.D;
            }
            if (RightHUD == true & Input.GetKeyDown("a"))
            {
                input = KeyCode.A;
            }

        }
        

    }

}
