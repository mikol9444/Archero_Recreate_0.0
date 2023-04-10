using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gewehr_test : Weapon_test
{
    public GameObject projectilePrefab;
    public Gewehr_test()
    {
        fireRate = 0.15f;
        damageType = new DamageType(10f, true);
    }
    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 1f, fireRate);
    }
    public override void Shoot()
    {
        // Code to shoot the pistol goes here
        base.Shoot();
        //Instantiate(projectilePrefab, shootingPoint.position, transform.parent.rotation);

        SpawnObjectFromPool("Projectile_Ge");
        AudioManager_Test.instance.PlaySound("Shoot");

    }
    public override GameObject SpawnObjectFromPool(string poolName)
    {
        GameObject obj = ObjectPooler.Instance.PoolObject(poolName); ;
        if (obj)
        {
            obj.transform.position = shootingPoint.position;
            obj.transform.forward = transform.forward;
            obj.GetComponent<Projectile_Test>().SetVelocity(transform.forward * bulletSpeed);
        }
        return obj;
    }
    public override void Reload()
    {
        // Code to reload the pistol goes here
        base.Reload();
    }
}
