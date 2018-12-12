using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

<<<<<<< HEAD
    GameObject scoreUITextGO;//UI do Game referencia

    public GameObject ExplosionGO;//prefab da explosão

	float speed;
	// Inicialização
	void Start () {
		speed = 1f;

        //UI do texto score
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreText");
	}
	

	void Update () {
		//Pega a atual posição da nave inimiga
		Vector2 position = transform.position;

		//Calcula a nova posição
		position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

		//Nova direção do inimigo
		transform.position = position;

		//Botao esquerdo
=======
    GameObject scoreUITextGO;//reference to the score text UI game object

    public GameObject ExplosionGO;//explosion prefab

	float speed;
	// Use this for initialization
	void Start () {
		speed = 1f;

        //get the score text UI
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		//Get the enemy current position
		Vector2 position = transform.position;

		//Compute the enemy new position
		position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

		//Update the enemy position
		transform.position = position;

		//Bottom-left position of the screen
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

		if (transform.position.y < min.y) {
			Destroy(gameObject);
		}

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if((col.tag == "PlayerShip") || (col.tag == "PlayerBullet"))
        {
            PlayExplosion();

<<<<<<< HEAD
            //adição de pontos no score
=======
            //add points to our score
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
            scoreUITextGO.GetComponent<GameScore>().Score += 100;

            Destroy(gameObject);
        }
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

<<<<<<< HEAD
        //Posição da explosão
=======
        //set the position of explosion
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
        explosion.transform.position = transform.position;

    }
}
















