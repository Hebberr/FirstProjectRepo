using UnityEngine;

public class EnemyWaves : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Enemy;
    public void SpawnEnemyWave(int enemyCount)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemySpawn = Instantiate(Enemy, transform.position, Quaternion.identity);
            enemySpawn.GetComponent<EnemyHealth>().eHealth += i;
            enemySpawn.GetComponent<EnemyHealth>().maxHealth += i;
            Debug.Log("Spawned enemy " + i);
        }
        Debug.Log("Wave Complete!");
    }
    void Start()
    {
        SpawnEnemyWave(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
