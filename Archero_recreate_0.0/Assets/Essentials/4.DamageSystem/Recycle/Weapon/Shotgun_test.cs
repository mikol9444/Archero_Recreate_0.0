using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun_test : Weapon_test
{
    public GameObject projectilePrefab;
    public Transform shootingPoint;
    public float bulletSpeed = 10f;
    public int numBullets = 5;
    public float spreadAngle = 30f;

    public Shotgun_test()
    {
        fireRate = 1f;
        damageType = new DamageType(5f, false);
    }

    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 1f, fireRate);
    }

    public override void Shoot()
    {
        // Code to shoot the shotgun goes here
        base.Shoot();

        float angleStep = spreadAngle / (numBullets - 1);
        float startAngle = -spreadAngle / 2f;

        for (int i = 0; i < numBullets; i++)
        {
            float angle = startAngle + i * angleStep;
            Quaternion rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + angle, transform.eulerAngles.z);
            SpawnObjectFromPool("Projectile_Sh", rotation);
        }

        AudioManager_Test.instance.PlaySound("Shoot");
    }

    public void SpawnObjectFromPool(string poolName, Quaternion rotation)
    {
        GameObject obj = ObjectPooler.Instance.PoolObject(poolName); ;
        if (obj)
        {
            obj.transform.position = shootingPoint.position;
            obj.transform.rotation = rotation;
            obj.GetComponent<Projectile>().SetVelocity(obj.transform.forward * bulletSpeed);
        }
    }

    public override void Reload()
    {
        // Code to reload the shotgun goes here
        base.Reload();
    }
}
