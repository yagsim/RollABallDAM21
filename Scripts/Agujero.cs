using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agujero : MonoBehaviour
{
    public string etiquetaDeObjetoACaer = "Bola";
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            Vector3 currentPosition = transform.position;
            Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + 1f, currentPosition.z);
            collision.gameObject.transform.position = newPosition;
            StartCoroutine(ReturnToInitialPosition(collision.gameObject));
        }
    }

    IEnumerator ReturnToInitialPosition(GameObject ball)
    {
        yield return new WaitForSeconds(1f);
        ball.transform.position = initialPosition;
    }
}