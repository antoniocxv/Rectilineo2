using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class softCurve : MonoBehaviour
{
    public Transform target; // El objetivo al que quieres apuntar
    public float rotationSpeed = 5.0f; // Velocidad de rotacion
    public float moveSpeed = 5.0f; // Velocidad de movimiento
    void Update()
    {
        if (target != null)
        {
            // Calcula la direccion hacia el objetivo
            Vector3 directionToTarget = target.position - transform.position;
            // Calcula la rotacion requerida para mirar hacia el objetivo
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);
            // Realiza una interpolacion suave entre la rotacion actual y la rotacion requerida
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            // Mueve al personaje hacia adelante en su direccion actual
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
