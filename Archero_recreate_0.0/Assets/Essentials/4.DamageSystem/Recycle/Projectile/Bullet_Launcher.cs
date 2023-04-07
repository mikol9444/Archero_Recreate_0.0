using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Launcher : Projectile
{
    public Bullet_Launcher()
    {
        speed = 5f;
        damage = 50;
    }
    public override void Fire()
    {
        //throw new System.NotImplementedException();
    }

    public override void Start()
    {
        base.Start();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}
