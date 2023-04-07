using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Projectile : MonoBehaviour
{


    protected Rigidbody rb;
    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void Fire()
    {
        Debug.Log($"fire {gameObject.name}");
    }
    public virtual void Stop()
    {
        Debug.Log($"Stop {gameObject.name}");
    }
    public virtual void OnEnable()
    {
        Fire();
    }
    public virtual void OnDisable()
    {
        Stop();
    }

    public virtual void SetVelocity(Vector3 dir) => rb.velocity = dir;
    protected virtual void OnTriggerEnter(Collider other)
    {
        // Code for handling collision with another object goes here
        if (other.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }
    }
}