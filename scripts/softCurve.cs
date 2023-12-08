using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class softCurve : MonoBehaviour
{
    public Transform target; // El objetivo al que quieres apuntar
    public float rotationSpeed = 5.0f; // Velocidad de rotación
    public float moveSpeed = 5.0f; // Velocidad de movimiento

    void Update()
    {
        if (target != null)
        {
            // Calcula la dirección hacia el objetivo
            Vector3 directionToTarget = target.position - transform.position;

            // Calcula la rotación requerida para mirar hacia el objetivo
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

            // Realiza una interpolación suave entre la rotación actual y la rotación requerida
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Mueve al personaje hacia adelante en su dirección actual
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
