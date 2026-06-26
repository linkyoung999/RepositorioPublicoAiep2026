using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{

    public string nombreDeEscena;
    public float tiempoDeEspera = 1f;
    public bool cambiarAlIniciar = false;

    void Start()
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
        if (!string.IsNullOrEmpty (nombreDeEscena))
        {
            SceneManager.LoadScene(nombreDeEscena);
        }
    }

}
