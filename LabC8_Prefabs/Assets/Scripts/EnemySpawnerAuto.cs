using UnityEngine;

public class EnemySpawnerAuto : MonoBehaviour
{
    public GameObject enemyFast;
    public GameObject enemyStrong;

    public float spawnTime = 2f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            Instantiate(enemyFast, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(enemyStrong, transform.position, Quaternion.identity);
        }
    }
}