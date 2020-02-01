using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFight : MonoBehaviour
{
        public Slider healthBar;
        
        public float health;
        public float maxHealth;

        public Robot robot;

        public Weapon weapon1;
        public Weapon weapon2;

        public Armor armor;

        public List<Item> items;

        private Rigidbody2D rigidbody2D;

        private void Awake()
        {
                rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 val)
        {
                rigidbody2D.AddForce(val);
        }

        public void UseWeapon1()
        {
                throw new NotImplementedException();
        }

        public void UseWeapon2()
        {
                throw new NotImplementedException();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
                
        }
}