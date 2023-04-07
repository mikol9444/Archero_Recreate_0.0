using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon_test : MonoBehaviour
{
    [SerializeField] protected float fireRate;
    [System.Serializable]
    public struct DamageType
    {
        public float damageAmount;
        public bool isPhysical;

        public DamageType(float damage, bool physical)
        {
            damageAmount = damage;
            isPhysical = physical;
        }
    }

    [SerializeField] protected DamageType damageType;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected float damage;
    [SerializeField] protected Transform shootingPoint;

    public virtual void Shoot()
    {
        // Code to shoot the weapon goes here
    }

    public virtual void Reload()
    {
        // Code to reload the weapon goes here
    }
    public virtual GameObject SpawnObjectFromPool(string poolName) => ObjectPooler.Instance.PoolObject(poolName);


}


