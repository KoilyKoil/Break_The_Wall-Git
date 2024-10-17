using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZA_WARUDO : MonoBehaviour
{
    public static bool PauseState = false;

    public void SetPause()
    {
        if (PauseState == false)
        {
            Time.timeScale = 0;
            PauseState = true;
        }
        else
        {
            Time.timeScale = 1;
            PauseState = false;
        }
    }
}
