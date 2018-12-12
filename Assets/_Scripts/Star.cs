using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {

    public float speed;

<<<<<<< HEAD
	// Inicialização..
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
        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

<<<<<<< HEAD
=======
        //If the star goes outside the screen on the bottom, then position star on the top
        //edge of the screen and randomly between the left and right side of the screen.
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
        if(transform.position.y < min.y)
        {
            transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
        }
	}
}
