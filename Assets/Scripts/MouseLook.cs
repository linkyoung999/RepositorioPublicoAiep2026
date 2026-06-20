using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensibilidadRaton = 100f;
    public Transform cuerpoJugador;

    private float rotacionX = 0f;
    private float rotacionY = 0f; // Añadimos esto para manejar la rotación horizontal aquí de forma limpia

    void Update()
    {
        // 1. Obtener datos del ratón simplificados
        float ratonX = Input.GetAxis("Mouse X") * sensibilidadRaton * Time.deltaTime;
        float ratonY = Input.GetAxis("Mouse Y") * sensibilidadRaton * Time.deltaTime;

        // 2. Acumular rotaciones
        rotacionX -= ratonY;
        rotacionX = Mathf.Clamp(rotacionX, -60f, 60f); // Límite vertical

        rotacionY += ratonX; // Acumula el movimiento horizontal

        // 3. Aplicar rotación combinada a la cámara directamente 
        // Esto evita pelearse con las físicas o el transform.Translate del cuerpo
        transform.localRotation = Quaternion.Euler(rotacionX, rotacionY, 0f);

        // 4. Hacer que el cuerpo solo siga la rotación horizontal en el mundo
        if (cuerpoJugador != null)
        {
            cuerpoJugador.rotation = Quaternion.Euler(0f, rotacionY, 0f);
        }
    }
}