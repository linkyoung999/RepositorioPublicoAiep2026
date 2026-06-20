using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimple : MonoBehaviour
{

    public float velocidad = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        
        //Llamamos el Vector3 para movernos en el eje X Y Z
       Vector3 direccion = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        

        // damos las instrucciones de como queremos movernos en el entorno
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
