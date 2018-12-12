using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float speed;
	Vector2 _direction; //direção da bala 
	bool isReady; 

	void Awake() {
		speed = 5f;
		isReady = false;
	}

	// Inicialização
	void Start () {
	
	}

	public void SetDirection(Vector2 direction) {
		_direction = direction.normalized;
		isReady = true;
	}
	
	// Método chamado a cada frame
	void Update () {
		if (isReady) {
			//Pegar a direção da bala
			Vector2 position = transform.position;

			//Calculando a direção da bala 
			position += _direction * speed * Time.deltaTime;

			//Nova direção da bala 
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
