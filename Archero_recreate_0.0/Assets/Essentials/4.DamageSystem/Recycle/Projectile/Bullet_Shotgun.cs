using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet_Shotgun : Projectile
{
    public Bullet_Shotgun()
    {
        speed = 15f;
        damage = 20f;
    }

    public override void Fire()
    {
        // Code for firing a shotgun bullet goes here
        // Set the initial velocity of the bullet based on its speed
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        // Code for handling collision with another object for shotgun bullet goes here
    }
}