using UnityEngine;
using UnityEngine.VFX;

namespace Weapons
{
    public class ConfettiGun : Weapon
    {
        public GameObject bulletPrefab;
        public float bulletSpeed;

        public VisualEffect fx;
        protected override void UseWeapon()
        {
            var dir = fighter.playerIndex == 0 ? fighter.transform.right : -fighter.transform.right;
            var bullet = Instantiate(bulletPrefab, dir + fighter.robot.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = (new Vector2(1, 0) * dir * bulletSpeed);
            bullet.GetComponent<Attack>().amount = amount;

            var yes = Instantiate(fx, dir + fighter.robot.transform.position, fx.transform.rotation);
            
            Destroy(yes, 3);

            Destroy(bullet, 3f);
        }

        public override EWeaponType GetWeaponType()
        {
            return EWeaponType.Ranged;
        }
    }
}