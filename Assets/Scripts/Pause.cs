using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    private bool estaPausado = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (estaPausado) ResumeGame();
            else PauseGame();
        }
    }

    public void PauseGame()
    {
        estaPausado = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        estaPausado = false;
        Time.timeScale = 1f;
    }
}
