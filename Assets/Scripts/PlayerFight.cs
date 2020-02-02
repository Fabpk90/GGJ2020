using System;
using System.Collections.Generic;
using System.Threading;
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
        private static readonly int BigBoi = Animator.StringToHash("BigBoi");
        private static readonly int Shot = Animator.StringToHash("Shot");
        private static readonly int Melee = Animator.StringToHash("Melee");
        private static readonly int Walking = Animator.StringToHash("Walking");

        private void Update()
        {
                Vector2 velocity = rigidbody2D.velocity;
                velocity.x =  movement * movementSpeed;
                rigidbody2D.velocity = velocity;
        }

        private void Awake()
        {
                rigidbody2D = robot.GetComponent<Rigidbody2D>();
                robot.GetComponent<Robot>().isBigBoi = playerIndex == 0;
                healthBar.maxValue = maxHealth;
                healthBar.value =maxHealth - health;
        }

        public void Move(Vector2 val)
        {
                if (val.x > 0)
                {
                        movement = 1;
                        robot.GetComponent<Robot>().legAnimator.SetBool(Walking, true);
                }
                        
                else if (val.x < 0)
                {
                        movement = -1;
                        robot.GetComponent<Robot>().legAnimator.SetBool(Walking, true);
                }
                       
                else
                {
                        movement = 0;
                        robot.GetComponent<Robot>().legAnimator.SetBool(Walking, false);
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
                {
                        robot.GetComponent<Robot>().weapon2
                                .SetBool(weapon2.GetWeaponType() == Weapon.EWeaponType.Ranged ? Shot : Melee,
                                        weapon2.Use());
                }
                        
        }

        public void TakeDamage(float amount)
        {
                health -= amount;
                healthBar.value = maxHealth - health;
                if (health < 0)
                        Die();
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
                                                robot.GetComponent<Robot>().weapon1Sprite.sprite =
                                                        weapon1.GetComponent<SpriteRenderer>().sprite;
                                        }
                                                
                                        else
                                        {
                                                weapon2 = item as Weapon;
                                                //TODO: enable that when the left side is done
                                                // robot.GetComponent<Robot>().weapon2Sprite.sprite =
                                                //         weapon2.GetComponent<SpriteRenderer>().sprite;
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
                if (canJump)
                {
                        //is it the right one ?
                        rigidbody2D.velocity += new Vector2(0, 1 ) * jumpHeight;
                        canJump = false;
                }
                        
        }
}