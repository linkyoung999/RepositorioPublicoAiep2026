using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocidad = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float movientoHorizontal = Input.GetAxis("Horizontal");
        float movientoVertical = Input.GetAxis("Vertical");



        //Llamamos el vector3 para movernos en los ejes X Y Z
        Vector3 direccion = new Vector3(movientoHorizontal, 0.0f, movientoVertical);


        // nos desplazamos en el mundo multiplicado por la escala de tiempo
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
