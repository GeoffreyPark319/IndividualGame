using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetStats : MonoBehaviour
{
    public int EnemyHealth = 5;

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            //Adds to score when enemy dies
            ScoringSystem.theScore += 25;

            Died();
        }
    }

    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
    }

    private void Died()
    {
        Destroy(gameObject);
    }
}
