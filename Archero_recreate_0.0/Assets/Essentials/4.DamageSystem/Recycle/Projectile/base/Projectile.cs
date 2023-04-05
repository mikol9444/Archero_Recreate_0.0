using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Projectile : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float damage;
    private Rigidbody rb;

    public abstract void Fire();
    public virtual void Start()
    {
        Fire();
    }
    public void SetVelocity(Vector3 dir) => GetComponent<Rigidbody>().velocity = dir;
    protected virtual void OnTriggerEnter(Collider other)
    {
        // Code for handling collision with another object goes here
        if (other.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }
    }
}