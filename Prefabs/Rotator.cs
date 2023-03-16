using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{

    public float rotationspeed=180f;

	
    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up* rotationspeed * Time.deltaTime); 
    }
}

