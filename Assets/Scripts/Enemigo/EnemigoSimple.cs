using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSimple : MonoBehaviour
{
    [Header("Configuracion de Activacion")]
    public GameObject objetoAActivar;

    [Header("Configuracion de Destruccion")]
    public GameObject[] objetosADestruir;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            ActivarObjeto();
            DestruirArrayDeObjetos();

            // Desactiva este script despues de ejecutarse para que no vuelva a funcionar
            enabled = false;
        }
    }

    private void ActivarObjeto()
    {
        if (objetoAActivar != null)
        {
            objetoAActivar.SetActive(true);
        }
    }

    private void DestruirArrayDeObjetos()
    {
        foreach (GameObject objeto in objetosADestruir)
        {
            if (objeto != null)
            {
                Destroy(objeto);
            }
        }
    }
}
