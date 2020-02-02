using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public PlayerFight player;

    public Animator legAnimator;

    public Animator weapon1;
    public SpriteRenderer weapon1Sprite;
    
    public Animator weapon2;
    public SpriteRenderer weapon2Sprite;

    public bool isBigBoi;
    private static readonly int BigBoi = Animator.StringToHash("BigBoi");

    private void Start()
    {
        //weapon1.SetBool(BigBoi, isBigBoi);
        weapon2.SetBool(BigBoi, isBigBoi);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        player.Collision(other);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.Trigger(other);
    }
}
