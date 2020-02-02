using System;
using UnityEngine;

public abstract class Weapon : Item
{
        public enum EWeaponType
        {
                Melee,
                Ranged
        }
        
        
        public float useCooldown;
        protected float cooldown;

        public PlayerFight fighter;

        protected abstract void UseWeapon();

        private void Update()
        { 
                cooldown += Time.deltaTime;
        }

        public bool Use()
        {
                if (cooldown >= useCooldown)
                {
                        cooldown = 0;
                        UseWeapon();
                        return true;
                }

                return false;
        }

        public override void TakeDamage(ref float amount)
        {
        }
        
        public override void DealDamage(ref float amount)
        {
        }
        
        public override void Equip(ref PlayerFight robot)
        {
                fighter = robot;
        }

        public override void UnEquip(ref PlayerFight robot)
        {
               
        }

        public override EType GetItemType()
        {
                return EType.Weapon;
        }

        public abstract EWeaponType GetWeaponType();
}