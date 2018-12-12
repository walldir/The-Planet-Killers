using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
<<<<<<< HEAD
	public GameObject EnemyGO; //prefab inimigo

	float maxSpawnRateInSeconds = 5f;
	// Inicialização..
=======
	public GameObject EnemyGO; //enemy prefab

	float maxSpawnRateInSeconds = 5f;
	// Use this for initialization
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Start () {
		
	}
	
<<<<<<< HEAD
=======
	// Update is called once per frame
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Update () {
	
	}

	void SpawnEnemy() {
<<<<<<< HEAD
		//Ponto esquerdo inferior da tela
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

		//Ponto direito superior da tela
=======
		//bottom-left point ofthe screen
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

		//right-top point ofthe screen
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

		GameObject anEnemy = (GameObject)Instantiate (EnemyGO);
		anEnemy.transform.position = new Vector2 (Random.Range (min.x, max.x), max.y);

		ScheduleNextEnemySpawn ();
	}

	void ScheduleNextEnemySpawn() {
		float spawnInNSeconds;

		if (maxSpawnRateInSeconds > 1f) {
			spawnInNSeconds = Random.Range (1f, maxSpawnRateInSeconds);
		} else {
			spawnInNSeconds = 1f;
		}

		Invoke ("SpawnEnemy", spawnInNSeconds);
	}

	void IncreaseSpawnRate() {		
		if(maxSpawnRateInSeconds > 1f) {
			maxSpawnRateInSeconds --;
		}
		if(maxSpawnRateInSeconds == 1f) {
			CancelInvoke("IncreaseSpawnRate");
		}
		
	}

<<<<<<< HEAD
    //Respawn da nave inimiga
=======
    //Start enemy spawning
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    public void ScheduleEnemySpawner()
    {
        maxSpawnRateInSeconds = 5f;

        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

<<<<<<< HEAD
        //Incrementação do spawn
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    } 

    
=======
        //Increase spawn rate every 30 seconds
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    } 

    //Stop enemy spawning
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    public void UnscheduleEnemySpawning()
    {
        CancelInvoke("SpawnEnemy");
        CancelInvoke("IncreaseSpawnRate");
    }
}







































