using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class softCurve : MonoBehaviour
{
    public Transform target; // El objetivo al que quieres apuntar
    public float rotationSpeed = 5.0f; // Velocidad de rotaci�n
    public float moveSpeed = 5.0f; // Velocidad de movimiento

    void Update()
    {
        if (target != null)
        {
            // Calcula la direcci�n hacia el objetivo
            Vector3 directionToTarget = target.position - transform.position;

            // Calcula la rotaci�n requerida para mirar hacia el objetivo
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

            // Realiza una interpolaci�n suave entre la rotaci�n actual y la rotaci�n requerida
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Mueve al personaje hacia adelante en su direcci�n actual
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
