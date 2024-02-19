using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int yPos;
    public int enemyCount;
    public int enemyLimit;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        if(enemyCount > enemyLimit)
        {
            stop = true;
        }
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            xPos = Random.Range(-13, 13);
            zPos = Random.Range(15, 30);
            yPos = Random.Range(2, 10);
            Vector3 spawnPosition = new Vector3(xPos, yPos, zPos);

            Instantiate(theEnemy, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
            enemyCount += 1;
        }
    }
}
