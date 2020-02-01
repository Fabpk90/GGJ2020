using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeapon : Weapon
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public override void Equip(ref PlayerFight robot)
    {
        throw new System.NotImplementedException();
    }

    public override void UnEquip(ref PlayerFight robot)
    {
        throw new System.NotImplementedException();
    }

    public override void UseWeapon()
    {
        Instantiate(bulletPrefab, transform.forward + transform.position, Quaternion.identity)
            .GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0) * transform.forward * bulletSpeed);
    }
}
