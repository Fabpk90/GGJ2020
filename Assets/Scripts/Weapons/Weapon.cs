using System;
using UnityEngine;

public abstract class Weapon : Item
{
        public float useCooldown;
        protected float cooldown;

        public abstract void UseWeapon();

        private void Update()
        { 
                cooldown += Time.deltaTime;
        }

        public void Use()
        {
                if (cooldown >= useCooldown)
                {
                        cooldown = 0;
                        UseWeapon();
                }
        }

        public override void TakeDamage(ref float amount)
        {
        }
        
        public override void DealDamage(ref float amount)
        {
        }
        
        public override void Equip(ref PlayerFight robot)
        {
                
        }

        public override void UnEquip(ref PlayerFight robot)
        {
               
        }
}