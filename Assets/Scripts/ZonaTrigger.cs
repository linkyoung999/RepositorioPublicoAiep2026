using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaTrigger : MonoBehaviour
{
    [Header("Configuración de Activación")]
    public GameObject objetoAActivar;

    [Header("Configuración de Destrucción")]
    public GameObject[] objetosADestruir;

    // Este método se ejecuta automáticamente cuando algo entra al Trigger
    private void OnTriggerEnter(Collider other)
    {
        // Validamos que sea el jugador usando su Tag
        if (other.CompareTag("Player"))
        {
            ActivarObjeto();
            DestruirArrayDeObjetos();
            
            // Opcional: Desactivar este script o componente para que no se vuelva a ejecutar
            enabled = false; 
        }
    }

    private void ActivarObjeto()
    {
        // Validamos que no esté nulo para evitar un NullReferenceException
        if (objetoAActivar != null)
        {
            objetoAActivar.SetActive(true);
        }
    }

    private void DestruirArrayDeObjetos()
    {
        // Recorremos el array de forma limpia con un foreach
        foreach (GameObject objeto in objetosADestruir)
        {
            if (objeto != null)
            {
                Destroy(objeto);
            }
        }
    }
}
