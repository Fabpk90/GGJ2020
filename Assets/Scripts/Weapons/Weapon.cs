using UnityEngine;

public abstract class Weapon : Item
{
        public float useCooldown;
        public abstract void Use();
}