using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(ShouldDieFromCollision(collision))
        {
            Die();
        }      
    }

    private bool ShouldDieFromCollision(Collision2D collision)
    {
        Penguin penguin = collision.gameObject.GetComponent<Penguin>();
        if (penguin != null)
            return true;

        if (collision.contacts[0].normal.y < -0.5)
            return true;

        return false;
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}
