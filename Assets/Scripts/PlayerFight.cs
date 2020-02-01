using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFight : MonoBehaviour
{
        public Slider healthBar;
        
        public float health;
        public float maxHealth;

        public GameObject robot;
        public GameObject projectileSpawnPoint;

        public Weapon weapon1;
        public Weapon weapon2;

        public Armor armor;

        public List<Item> items;

        private new Rigidbody2D rigidbody2D;

        private float movement;

        private void Update()
        {
                rigidbody2D.velocity = new Vector3(1, 0) * movement;
        }

        private void Awake()
        {
                rigidbody2D = robot.GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 val)
        {
                if (val.x > 0)
                        movement = 1;
                else if (val.x < 0)
                        movement = -1;
                else
                {
                        movement = 0;
                }
        }

        public void UseWeapon1()
        {
                if(weapon1 != null)
                        weapon1.Use();
        }

        public void UseWeapon2()
        {
                if (weapon2 != null) 
                        weapon2.Use();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
                
        }
}