using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Penguin penguin = collision.gameObject.GetComponent<Penguin>();
        if (penguin != null)
            gameObject.SetActive(false);
    }
}
