using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionObjetoInfinito : MonoBehaviour
{

    [Header ("Ajustes de Rotacion")]
    public float velocidad =50f;
    public bool rotarX;
    public bool rotarY;

    // Update is called once per frame
    void Update()
    {
        Vector3 direcion =Vector3.zero;
        if (rotarX) direcion = Vector3.left;
        else if (rotarY) direcion = Vector3.up;

        if (direcion != Vector3.zero)
        {
            transform.Rotate(direcion * (velocidad * Time.deltaTime));
        }
    }
}
