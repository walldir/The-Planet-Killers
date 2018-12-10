﻿using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float speed;
	Vector2 _direction; //direction of the bullet
	bool isReady; //to know when the bullet direction is set

	void Awake() {
		speed = 5f;
		isReady = false;
	}

	// Use this for initialization
	void Start () {
	
	}

	public void SetDirection(Vector2 direction) {
		//set the direction normalized, to get an unit vector
		_direction = direction.normalized;
		isReady = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (isReady) {
			//get the bullet's current position
			Vector2 position = transform.position;

			//compute the bullet's new position 
			position += _direction * speed * Time.deltaTime;

			//update the bullet's position 
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
