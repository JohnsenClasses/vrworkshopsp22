using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool spawning;
    public Enemy enemyPrefab;
    public List<Enemy> enemies = new List<Enemy>();
    public Goal goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startSpawning(float spawnRate)
    {

        StartCoroutine(doSpawnBehavior(spawnRate));
    }

    public void stopSpawnng()
    {
        spawning = false;
    }

    IEnumerator doSpawnBehavior(float spawnRate)
    {
        spawning = true;
        while (spawning)
        {
            Enemy enemy = Instantiate<Enemy>(enemyPrefab);
            enemy.transform.position = this.transform.position;
            enemies.Add(enemy);
            enemy.setTarget(goal.gameObject);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
