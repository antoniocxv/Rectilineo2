using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goForward : MonoBehaviour
{
    public Transform target; // El objetivo al que queremos mover el personaje
    public float moveSpeed = 5.0f; // Velocidad de movimiento del personaje
    public float rotationSpeed = 1.0f; // Velocidad de rotaci�n del personaje
    public float jitterThreshold = 0.1f; // Umbral para controlar el jitter

    void Update()
    {
        if (target != null)
        {
            // Calcula la direcci�n hacia el objetivo
            Vector3 direction = target.position - transform.position;

            // Verifica si la magnitud de la direcci�n es mayor que el umbral de jitter
            if (direction.magnitude > jitterThreshold)
            {
                // Normaliza la direcci�n para evitar la influencia de la magnitud del vector
                direction.Normalize();

                // Calcula la rotaci�n para mirar hacia el objetivo
                Quaternion rotation = Quaternion.LookRotation(direction);

                // Aplica la rotaci�n al personaje suavemente
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

                // Mueve al personaje hacia adelante en la direcci�n del objetivo
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
        }
    }
}
