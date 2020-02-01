using UnityEngine;

public abstract class Armor : Item
{
        public new string name;

        public override void TakeDamage(ref float damageAmount)
        {
                damageAmount -= (damageAmount * amount);
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