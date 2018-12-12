using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
	public GameObject EnemyBulletGO; //prefab da bala inimiga 
	// Inicialização..
	void Start () {
		Invoke ("FireEnemyBullet", 1f);
	}
	

	void Update () {
		
	}

	void FireEnemyBullet() {
		//referencia da posição da nave inimiga
		GameObject playerShip = GameObject.Find("PlayerGO");

		if (playerShip != null) {
			GameObject bullet = (GameObject) Instantiate(EnemyBulletGO);

			//Setando a bala inimiga pra posição inicial
			bullet.transform.position = transform.position;

			//Calculando a direção da bala da nave inimiga
			Vector2 direction = playerShip.transform.position - bullet.transform.position;

			bullet.GetComponent<EnemyBullet>().SetDirection(direction);
		}
	}
}
