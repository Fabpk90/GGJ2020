using UnityEngine;

namespace Weapons
{
    public class MeleeWeapon : Weapon
    {
        protected override void UseWeapon()
        {
            var dir = fighter.playerIndex == 0 ? Vector2.right : Vector2.left;
            
            Debug.DrawLine(fighter.transform.position, dir);
            
            var hit = Physics2D.Raycast(fighter.transform.position, dir, 1.0f);
            if(hit)
            {
                Robot r = hit.transform.GetComponent<Robot>();

                if (r)
                {
                    if (r != fighter.robot.GetComponent<Robot>())
                    {
                        r.player.TakeDamage(amount);
                    }
                }
            }
        }

        public override EWeaponType GetWeaponType()
        {
            return EWeaponType.Melee;
        }
    }
}