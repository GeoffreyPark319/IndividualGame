using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Checks to see if the bullet collides with the player gameObject.
        if (collision.gameObject.tag == "Player")
        {
            //Add points of damage to the Player GameObject
            //Then destroy the bullet
            //Then Player is then damaged
            collision.gameObject.GetComponent<PlayerStats>().TakeDamage(5);
            Destroy(gameObject);
        }
    }
}
