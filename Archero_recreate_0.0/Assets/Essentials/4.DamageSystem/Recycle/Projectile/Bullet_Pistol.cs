using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet_Pistol : Projectile_Test
{
    public override void Fire()
    {
        base.Fire();
    }
    public override void OnEnable()
    {
        base.OnEnable();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        // Code for handling collision with another object for pistol bullet goes here

    }
}