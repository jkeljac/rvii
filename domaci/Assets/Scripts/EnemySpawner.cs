using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;


public class EnemySpawner : MonoBehaviour
{
    
    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    public List<Transform> spawnPoints;
    public int numberOfEnemies;
    
    private void Awake()
    {
        spawnedEnemies = new List<GameObject>();
    }

    
    public GameObject SpawnEnemy(){
        
        System.Random random = new System.Random();
        int index = random.Next(0, spawnPoints.Count);
        GameObject prefab = Instantiate(enemyPrefab,spawnPoints[index].position,Quaternion.identity);
        return prefab;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<numberOfEnemies;i++){
            GameObject enemy = SpawnEnemy();
            spawnedEnemies.Add(enemy);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
