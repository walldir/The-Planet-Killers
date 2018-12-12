using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
<<<<<<< HEAD
	public GameObject EnemyBulletGO; //prefab da bala inimiga 
	// Inicialização..
=======
	public GameObject EnemyBulletGO; //Enemy bullet prefab
	// Use this for initialization
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Start () {
		Invoke ("FireEnemyBullet", 1f);
	}
	
<<<<<<< HEAD

=======
	// Update is called once per frame
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Update () {
		
	}

	void FireEnemyBullet() {
<<<<<<< HEAD
		//referencia da posição da nave inimiga
=======
		//get a reference to the player's ship
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
		GameObject playerShip = GameObject.Find("PlayerGO");

		if (playerShip != null) {
			GameObject bullet = (GameObject) Instantiate(EnemyBulletGO);

<<<<<<< HEAD
			//Setando a bala inimiga pra posição inicial
			bullet.transform.position = transform.position;

			//Calculando a direção da bala da nave inimiga
=======
			//set the bullet's initial position
			bullet.transform.position = transform.position;

			//compute bullet's direction towards playership
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
			Vector2 direction = playerShip.transform.position - bullet.transform.position;

			bullet.GetComponent<EnemyBullet>().SetDirection(direction);
		}
	}
}
