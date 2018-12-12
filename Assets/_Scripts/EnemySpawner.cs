using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject EnemyGO; //prefab inimigo

	float maxSpawnRateInSeconds = 5f;
	// Inicialização..
	void Start () {
		
	}
	
	void Update () {
	
	}

	void SpawnEnemy() {
		//Ponto esquerdo inferior da tela
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

		//Ponto direito superior da tela
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

    //Respawn da nave inimiga
    public void ScheduleEnemySpawner()
    {
        maxSpawnRateInSeconds = 5f;

        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        //Incrementação do spawn
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    } 

    
    public void UnscheduleEnemySpawning()
    {
        CancelInvoke("SpawnEnemy");
        CancelInvoke("IncreaseSpawnRate");
    }
}







































