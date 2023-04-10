using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Projectile_Test : MonoBehaviour
{


    protected Rigidbody rb;
    [SerializeField] protected float deactivateTimer = 5f;
    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void Fire()
    {
        Debug.Log($"fire {gameObject.name}");
        Invoke(nameof(Deactivate), deactivateTimer);
    }
    public virtual void Deactivate() => gameObject.SetActive(false);
    public virtual void Stop()
    {
        Debug.Log($"Stop {gameObject.name}");
        CancelInvoke(nameof(Deactivate));

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