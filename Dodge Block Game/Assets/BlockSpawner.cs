using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeToSpawn = 2f;

    public float timeBetweenWaves = 1f;

	// Use this for initialization
	void Update () {

        if (Time.time >= timeToSpawn)
        {
            spawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }       
        
	}

    void spawnBlocks () {

        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {

            if (randomIndex != i)
            {

                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);

            }

        }   
    
    }
	
	
}
