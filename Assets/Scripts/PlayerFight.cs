﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFight : MonoBehaviour
{
        public int playerIndex;
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

        public float movementSpeed;
        public float jumpHeight;
        private float movement;
        private bool canJump = true;
        private bool isJumping;

        private void Update()
        {
                Vector2 velocity = rigidbody2D.velocity;
                velocity.x =  movement * movementSpeed;
                rigidbody2D.velocity = velocity;
        }

        private void Awake()
        {
                rigidbody2D = robot.GetComponent<Rigidbody2D>();
                healthBar.maxValue = maxHealth;
                healthBar.value = health;
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

        public void TakeDamage(float amount)
        {
                health -= amount;

                if (health < 0)
                        Die();
                else
                {
                        healthBar.value = health;
                }
        }

        private void Die()
        {
                GameManager.Instance.PlayerDie(playerIndex);
        }

        public void Collision(Collision2D other)
        {
                Attack p = other.gameObject.GetComponent<Attack>();

                if (p)
                {
                        float damage = p.amount;

                        foreach (Item item in items)
                        {
                                item.TakeDamage(ref damage);
                        }
                        TakeDamage(damage);
                        print("collision");
                        
                        Destroy(p.gameObject);
                }
                else
                {
                        canJump = true;
                }
        }

        public void Trigger(Collider2D other)
        {
                Attack p = other.gameObject.GetComponent<Attack>();

                if (p)
                {
                        float damage = p.amount;

                        foreach (Item item in items)
                        {
                                item.TakeDamage(ref damage);
                        }
                        
                        TakeDamage(damage);
                        
                        print("trigger");
                        Destroy(p.gameObject);
                }
        }

        public void GetTheDump(List<Item> walletItems)
        {
                foreach (Item item in walletItems)
                {
                        switch (item.GetItemType())
                        {
                                case Item.EType.Weapon:
                                        if (!weapon1)
                                        {
                                                weapon1 = item as Weapon;
                                        }
                                                
                                        else
                                        {
                                                weapon2 = item as Weapon;
                                        }
                                        break;
                                case Item.EType.Armor:
                                        armor = item as Armor;
                                        break;
                                case Item.EType.Boots:
                                        print("we don't that sorry");
                                        break;
                        }

                        
                }
                
                items.AddRange(walletItems);

                foreach (Item item in walletItems)
                {
                        //useless mess
                        PlayerFight fight = this;
                        item.Equip(ref fight);
                }
        }

        public void Jump()
        {
                print("jump !");
                if (canJump)
                {
                        //is it the right one ?
                        rigidbody2D.velocity += new Vector2(0, 1 ) * jumpHeight;
                        canJump = false;
                }
                        
        }
}