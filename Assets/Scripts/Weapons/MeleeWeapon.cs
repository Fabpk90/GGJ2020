using UnityEngine;

namespace Weapons
{
    public class MeleeWeapon : Weapon
    {
        protected override void UseWeapon()
        {
            
        }

        public override EWeaponType GetWeaponType()
        {
            return EWeaponType.Melee;
        }
    }
}