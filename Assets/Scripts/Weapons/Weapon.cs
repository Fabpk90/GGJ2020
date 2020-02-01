using UnityEngine;

public abstract class Weapon : Item
{
        public float useCooldown;
        public abstract void Use();
        
        public override void TakeDamage(ref float amount)
        {
        }
        
        public override void DealDamage(ref float amount)
        {
        }
        
        public override void Equip(ref Robot robot)
        {
                
        }

        public override void UnEquip(ref Robot robot)
        {
               
        }
}