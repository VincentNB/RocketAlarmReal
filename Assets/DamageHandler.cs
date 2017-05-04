using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

    public int health = 10;
    public int dmg = 1;
    public GameObject ship;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        health -= collision.gameObject.GetComponent<DamageHandler>().dmg;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Update()
    {/*
        if (ship.GetComponent<DamageHandler>().health <= 0)
        {
            print("EXPLOSION");
            audio.PlayOneShot(xpl, 1);
            Die();
        }
        else if(health <= 0)
        {
            Die();
        }*/
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
