using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

	// Use this for initialization
	void Start () {

        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++) {

            if (randomIndex != i) {

                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            
            }
        
        }
        
	}
	
	
}
