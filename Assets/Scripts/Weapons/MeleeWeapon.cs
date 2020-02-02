using UnityEngine;

namespace Weapons
{
    public class MeleeWeapon : Weapon
    {
        public override EWeaponType GetWeaponType()
        {
            return EWeaponType.Melee;
        }
    }
}