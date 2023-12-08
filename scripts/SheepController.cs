using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento del cilindro.

    void Update()
    {
        // Obtén las entradas del teclado para las teclas de flecha.
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula la dirección del movimiento.
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);

        // Aplica la fuerza al cilindro para moverlo.
        GetComponent<Rigidbody>().AddForce(movimiento * velocidad); 
    }
}
