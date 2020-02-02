using UnityEngine;

namespace Weapons
{
    public class MeleeWeapon : Weapon
    {
        protected override void UseWeapon()
        {
            var dir = fighter.playerIndex == 0 ? Vector2.right : Vector2.left;
            
            Debug.DrawLine(fighter.robot.transform.position, dir);
            Vector2 position;
            position.x = fighter.robot.transform.position.x;
            position.y = fighter.robot.transform.position.y;
            var hit = Physics2D.Raycast(position + dir, dir, 1.0f);
            if(hit)
            {
                print("yes");
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