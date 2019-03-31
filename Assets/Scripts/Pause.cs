using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    bool isPause;

    void PauseC()
    {
        Time.timeScale = 0;
    }

    void UnPause()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPause = !isPause;

            if (isPause)
            {
                PauseC();
            }
            else
            {
                UnPause();
            }
        }
    }
}