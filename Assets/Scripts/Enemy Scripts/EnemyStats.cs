using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    private WaveSpawner waveSpawner;

    public int EnemyHealth = 20;

    private void Start()
    {
        waveSpawner = GetComponentInParent<WaveSpawner>();
    }

    void Update()
    {
        if(EnemyHealth <= 0)
        {
            //Adds to score when enemy dies
            ScoringSystem.theScore += 100;

            Died();
        }
    }

    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;

        GameObject CanvasChild = transform.GetChild(0).gameObject;
        GameObject HealthBarChild = CanvasChild.transform.GetChild(0).gameObject;
        HealthBarChild.GetComponent<EnemyHealthBar>().ChangeHealth(EnemyHealth);
    }

    private void Died()
    {
        Destroy(gameObject);

        waveSpawner.waves[waveSpawner.currentWaveIndex].enemiesLeft--;
    }
}
