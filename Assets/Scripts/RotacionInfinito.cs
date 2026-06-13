using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionInfinito : MonoBehaviour
{

    [Header ("Ajuste de Rotacion")]
    public float velocidad = 50f;
    public bool rotarX;
    public bool rotarY;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (rotarX) direction = Vector3.right;
        else if (rotarY) direction = Vector3.up;


        if (direction != Vector3.zero)
        {
            transform.Rotate(direction * (velocidad * Time.deltaTime));


        }

    }

    private void OnValidate()
    {
        if (rotarX && rotarY)
        {
            rotarX = false;
        }
    }

}
