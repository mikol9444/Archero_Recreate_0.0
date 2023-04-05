using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol_test : Weapon_test
{
    public GameObject projectilePrefab;
    public Transform shootingPoint;
    public float bulletSpeed = 15f;
    public Pistol_test()
    {
        fireRate = 0.5f;
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

        SpawnObjectFromPool("Projectile_Pi");
        AudioManager_Test.instance.PlayOneShot();

    }
    public void SpawnObjectFromPool(string poolName)
    {
        GameObject obj = ObjectPooler.Instance.PoolObject(poolName); ;
        if (obj)
        {
            obj.transform.position = shootingPoint.position;
            obj.transform.rotation = transform.rotation;
            obj.GetComponent<Projectile>().SetVelocity(transform.forward * bulletSpeed);
        }
    }
    public override void Reload()
    {
        // Code to reload the pistol goes here
        base.Reload();
    }
}
