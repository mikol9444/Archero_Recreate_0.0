using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootUpObject : MonoBehaviour
{
    public float minForce = 10f;
    public float maxForce = 20f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Generate a random direction for the force
        Vector3 forceDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(0f, 1f), Random.Range(-1f, 1f)).normalized;

        // Generate a random force magnitude
        float forceMagnitude = Random.Range(minForce, maxForce);

        // Apply the force to the Rigidbody
        rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        //Destroy(gameObject, 1f);
    }
}
