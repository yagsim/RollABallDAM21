using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampController : MonoBehaviour
{
    public float speedMultiplier = 2f; // Velocidad multiplicadora al contacto
    public Rigidbody rb; // Referencia al rigidbody de la bola
    private float initialSpeed; // Velocidad inicial de la bola

    void Start()
    {
        initialSpeed = rb.velocity.magnitude;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            Vector3 direction = other.contacts[0].normal; // Dirección normal de la rampa en el punto de colisión
            rb.AddForce(direction * speedMultiplier, ForceMode.Impulse); // Agregar impulso a la bola
        }
        else if (other.gameObject.CompareTag("Suelo"))
        {
            rb.velocity = rb.velocity.normalized * initialSpeed; // Restaurar velocidad inicial
        }
    }
}

