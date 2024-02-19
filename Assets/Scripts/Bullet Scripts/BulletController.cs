using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Checks to see if the bullet collides with the enemy gameObject.
        if(collision.gameObject.tag == "Enemy")
        {
            //Add points of damage to the Enemy GameObject
            //Then destroy the bullet
            //Then enemy is then damaged
            collision.gameObject.GetComponent<EnemyStats>().TakeDamage(5);
            Destroy(gameObject);
        }
    }
}
