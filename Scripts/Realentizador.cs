using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realentizador : MonoBehaviour
{
    public float factorDeRealentizacion = 0.5f;
    public string etiquetaDelPlano = "Realentizador";

    private Collider colliderDelObjeto;
    private float friccionInicial;
    public Rigidbody rbBola;

    void Start()
    {
        colliderDelObjeto = GetComponent<Collider>();
        friccionInicial = colliderDelObjeto.material.dynamicFriction;

    
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(etiquetaDelPlano))
        {
            // Calcular la dirección opuesta a la velocidad actual de la bola
            Vector3 direccionOpuesta = -rbBola.velocity.normalized;
            
            // Aplicar una fuerza en la dirección opuesta con una magnitud proporcional al factor de realentización
            rbBola.AddForce(direccionOpuesta * factorDeRealentizacion, ForceMode.Impulse);

            // Cambiar la fricción dinámica del objeto colisionado para reducir su velocidad de movimiento
            colliderDelObjeto.material.dynamicFriction = friccionInicial * factorDeRealentizacion;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(etiquetaDelPlano))
        {
            // Restaurar la fricción dinámica original del objeto al salir de contacto con el objeto con la etiqueta "Realentizador"
            colliderDelObjeto.material.dynamicFriction = friccionInicial;
        }
    }
}