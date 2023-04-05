using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet_Pistol : Projectile
{
    public Bullet_Pistol()
    {
        speed = 20f;
        damage = 10f;
    }

    public override void Fire()
    {
        // Code for firing a pistol bullet goes here
        // Set the initial velocity of the bullet based on its speed
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;
        //rb.velocity *= speed;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        // Code for handling collision with another object for pistol bullet goes here

    }
}