using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
public abstract class Weapon_test : MonoBehaviour
{
    [SerializeField] protected float fireRate;
    [SerializeField] protected DamageType damageType;

    public virtual void Shoot()
    {
        // Code to shoot the weapon goes here
    }

    public virtual void Reload()
    {
        // Code to reload the weapon goes here
    }
}
