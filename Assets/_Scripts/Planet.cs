using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

    public float speed;
    public bool isMoving;

<<<<<<< HEAD
    Vector2 min;//Ponto esquerdo inferior da tela
    Vector2 max;//Ponto Direito superior da tela
=======
    Vector2 min;//bottom-left point of the screen
    Vector2 max;//top-right point of the screen
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108

    void Awake()
    {
        isMoving = false;

        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
<<<<<<< HEAD
        
        //Planeta Sprite
        max.y = max.y + GetComponent<SpriteRenderer>().sprite.bounds.extents.y;

=======

        //add the planet sprite half height to max y
        max.y = max.y + GetComponent<SpriteRenderer>().sprite.bounds.extents.y;

        //substract the planet sprite half height to min y
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
        min.y = min.y - GetComponent<SpriteRenderer>().sprite.bounds.extents.y;

    }

<<<<<<< HEAD
	// Inicialização
=======
	// Use this for initialization
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Start () {
	
	}
	
<<<<<<< HEAD
=======
	// Update is called once per frame
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Update () {
	    if(!isMoving)
        {
            return;
        }

<<<<<<< HEAD
        //Pegando a posição do planeta
        Vector2 position = transform.position;

        //Calculando a posição do planeta
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        //Atualizando a posição do planeta
        transform.position = position;

=======
        //Get the current position of the planet
        Vector2 position = transform.position;

        //Compute the planet's new position
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        //Update the planet's position
        transform.position = position;

        //If the planet gets to the minimum y position then stop moving it
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
        if(transform.position.y < min.y)
        {
            isMoving = false;
        }
	}

<<<<<<< HEAD
    //Resetar a posição do planeta
    public void ResetPosition()
    {        
=======
    //Reset the planet's position
    public void ResetPosition()
    {
        //reset the position of the planet to random x and max y
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
        transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
    }
}
