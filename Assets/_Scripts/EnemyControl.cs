using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

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

            //adição de pontos no score
            scoreUITextGO.GetComponent<GameScore>().Score += 100;

            Destroy(gameObject);
        }
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

        //Posição da explosão
        explosion.transform.position = transform.position;

    }
}
















