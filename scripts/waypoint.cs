using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class waypoint : MonoBehaviour
{
    public Transform[] targets; // Lista de objetivos (waypoints)
    public float moveSpeed = 5.0f; // Velocidad de movimiento del personaje
    public float rotationSpeed = 5.0f; // Velocidad de rotacion
    private int currentTargetIndex = 0;

    void Start()
    {
        if (targets.Length > 0)
        {
            // Inicialmente, el primer objetivo sera el objetivo actual
            SetTarget(targets[0]);
        }
    }

    void Update()
    {
        if (currentTargetIndex < targets.Length)
        {
            Transform target = targets[currentTargetIndex];
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
                // Calcula la distancia al objetivo actual
                float distanceToTarget = directionToTarget.magnitude;
                if (distanceToTarget < 0.1f)
                {
                    currentTargetIndex++;
                    if (currentTargetIndex < targets.Length)
                    {
                        SetTarget(targets[currentTargetIndex]);
                    }else
                    {
                            Debug.Log("Ha llegado a su destino. Comenzamos de nuevo /n");
                        currentTargetIndex = 0;
                    }
                }
            }
            



        }

    }

    private Transform target;

    void SetTarget(Transform newTarget)
    {
        // Establece el nuevo objetivo
        target = newTarget;
    }

}
