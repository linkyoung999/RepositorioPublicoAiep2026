using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarDeEscena : MonoBehaviour
{
    public string nombreEscena;
    public float tiempoDeEspera =1f;
    public bool cambiarAlIniciar = false;


    private void Start()
    {
        if (cambiarAlIniciar)
        {
            CambiarEscena();
        }
        
    }

    public void CambiarEscena()
    {
        Invoke("CargarEscenaYa", tiempoDeEspera);

    }

    public void CargarEscenaYa()
    {
        if (!string.IsNullOrEmpty (nombreEscena))
        {
            SceneManager.LoadScene(nombreEscena);
        }
    }

}
