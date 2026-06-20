using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirJuego : MonoBehaviour
{

    public void CerrarJuego()
    {
 #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
 #else       
        Application.Quit();
 #endif       
    }
}
