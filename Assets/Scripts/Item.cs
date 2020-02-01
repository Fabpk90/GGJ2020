using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [Range(0, 100)]
    public int weight;
    [Range(0, 100)]
    public float amount;

    public float secondsToPull;


    public abstract void TakeDamage(ref float amount);
    public abstract void DealDamage(ref float amount);

    public abstract void Equip(ref PlayerFight robot);
    public abstract void UnEquip(ref PlayerFight robot);
}