using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

    public float speed;
    public bool isMoving;

    Vector2 min;//Ponto esquerdo inferior da tela
    Vector2 max;//Ponto Direito superior da tela

    void Awake()
    {
        isMoving = false;

        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        
        //Planeta Sprite
        max.y = max.y + GetComponent<SpriteRenderer>().sprite.bounds.extents.y;

        min.y = min.y - GetComponent<SpriteRenderer>().sprite.bounds.extents.y;

    }

	// Inicialização
	void Start () {
	
	}
	
	void Update () {
	    if(!isMoving)
        {
            return;
        }

        //Pegando a posição do planeta
        Vector2 position = transform.position;

        //Calculando a posição do planeta
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        //Atualizando a posição do planeta
        transform.position = position;

        if(transform.position.y < min.y)
        {
            isMoving = false;
        }
	}

    //Resetar a posição do planeta
    public void ResetPosition()
    {        
        transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
    }
}
