using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeapon : Weapon
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    

    public override void UnEquip(ref PlayerFight robot)
    {
        throw new System.NotImplementedException();
    }

    public override EWeaponType GetWeaponType()
    {
        return EWeaponType.Ranged;
    }

    protected override void UseWeapon()
    {
        var dir = fighter.playerIndex == 0 ? fighter.robot.transform.right : -fighter.robot.transform.right;
        var bullet = Instantiate(bulletPrefab, dir + fighter.robot.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = (new Vector2(1, 0) * dir * bulletSpeed);
        bullet.GetComponent<Attack>().amount = amount;
        bullet.GetComponent<Attack>().playerIndex = fighter.playerIndex;
        
        Destroy(bullet, 3f);
    }
}
