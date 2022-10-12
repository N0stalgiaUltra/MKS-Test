using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{
    [SerializeField] private EnemyFactory enemyFactory;
    [SerializeField] private int enemiesQuantity;
    [SerializeField] private Queue<GameObject> enemyQueue = new Queue<GameObject>();
    [SerializeField] private Transform[] enemySpawns = new Transform[3];
    private int spawnTime;
    private float nextSpawn;


    private void Awake()
    {
        for (int i = 0; i < enemiesQuantity; i++)
        {
            GameObject aux = enemyFactory.GetNewInstance();
            enemyQueue.Enqueue(aux);
        }
        spawnTime = PlayerPrefs.GetInt("EnemySpawnTime");
        nextSpawn = spawnTime;
    }

    void Update()
    {
        nextSpawn -= Time.deltaTime;
        if (nextSpawn <= 0)
        {
            EnemySpawn(enemySpawns[Random.Range(0, enemySpawns.Length)]);
            nextSpawn = spawnTime;
        }
    }

    public void EnemySpawn(Transform enemySpawn)
    {
        if (enemyQueue.Count != 0)
        {
            GameObject aux = enemyQueue.Dequeue();

            aux.transform.SetPositionAndRotation(enemySpawn.transform.position, enemySpawn.transform.rotation);
            aux.SetActive(true);
        }
    }
    public void ReplenishQueue(GameObject enemy) => enemyQueue.Enqueue(enemy);

}
