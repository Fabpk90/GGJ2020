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
        
        public override void Equip(ref PlayerFight robot)
        {
        
        }

        public override void UnEquip(ref PlayerFight robot)
        {
        
        }

        public override EType GetItemType()
        {
                return EType.Armor;
        }
}