using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeapon : Weapon
{
    public GameObject bulletPrefab;
    public float bulletSpeed;

    private PlayerFight fighter;
    public override void Equip(ref PlayerFight robot)
    {
        fighter = robot;
    }

    public override void UnEquip(ref PlayerFight robot)
    {
        throw new System.NotImplementedException();
    }

    public override void UseWeapon()
    {
        var dir = fighter.playerIndex == 0 ? fighter.transform.right : -fighter.transform.right;
        var bullet = Instantiate(bulletPrefab, dir + fighter.robot.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = (new Vector2(1, 0) * dir * bulletSpeed);
        bullet.GetComponent<Attack>().amount = amount;
        
        Destroy(bullet, 3f);
    }
}
