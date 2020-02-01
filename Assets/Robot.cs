using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public PlayerFight player;

    private void OnCollisionEnter2D(Collision2D other)
    {
        player.collision(other);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.trigger(other);
    }
}
