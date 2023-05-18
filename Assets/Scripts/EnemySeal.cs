using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class EnemySeal : MonoBehaviour
{
    bool _hasDied;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(ShouldDieFromCollision(collision))
        {
            Die();
        }      
    }

    bool ShouldDieFromCollision(Collision2D collision)
    {
        if (_hasDied)
            return false;

        Penguin penguin = collision.gameObject.GetComponent<Penguin>();
        if (penguin != null)
            return true;

        if (collision.contacts[0].normal.y < -0.5)
            return true;

        return false;
    }

    void Die()
    {

        _hasDied = true;
        gameObject.SetActive(false);
    }
}
