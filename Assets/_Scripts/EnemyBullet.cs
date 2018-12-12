using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float speed;
<<<<<<< HEAD
	Vector2 _direction; //direção da bala 
	bool isReady; 
=======
	Vector2 _direction; //direction of the bullet
	bool isReady; //to know when the bullet direction is set
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108

	void Awake() {
		speed = 5f;
		isReady = false;
	}

<<<<<<< HEAD
	// Inicialização
=======
	// Use this for initialization
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Start () {
	
	}

	public void SetDirection(Vector2 direction) {
<<<<<<< HEAD
=======
		//set the direction normalized, to get an unit vector
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
		_direction = direction.normalized;
		isReady = true;
	}
	
<<<<<<< HEAD
	// Método chamado a cada frame
	void Update () {
		if (isReady) {
			//Pegar a direção da bala
			Vector2 position = transform.position;

			//Calculando a direção da bala 
			position += _direction * speed * Time.deltaTime;

			//Nova direção da bala 
=======
	// Update is called once per frame
	void Update () {
		if (isReady) {
			//get the bullet's current position
			Vector2 position = transform.position;

			//compute the bullet's new position 
			position += _direction * speed * Time.deltaTime;

			//update the bullet's position 
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
			transform.position = position;

			Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
			Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

			if((transform.position.x < min.x) || (transform.position.x > max.x) || 
			   (transform.position.y < min.y) || (transform.position.y > max.y)) {
				Destroy(gameObject);
			}

		}
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "PlayerShip")
        {
            Destroy(gameObject);
        }
    }
}
