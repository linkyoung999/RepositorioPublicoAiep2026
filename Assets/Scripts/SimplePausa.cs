using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePausa : MonoBehaviour
{

    public bool estaPausado = false;
    public GameObject canvasPausa;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (estaPausado) ContinuarJuego();
            else JuegoPausado();
        }
    }

    public void JuegoPausado()
    {
        estaPausado = true;
        Time.timeScale = 0f;

        if (canvasPausa != null) canvasPausa.SetActive(true);
    }

    public void ContinuarJuego()
    {
        estaPausado = false;
        Time.timeScale = 1f;

        if (canvasPausa != null) canvasPausa.SetActive(false);
    }
}
