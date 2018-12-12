using UnityEngine;
using System.Collections;

public class StarGenerator : MonoBehaviour {

<<<<<<< HEAD
    public GameObject StarGO;//Prefab da estrela
=======
    public GameObject StarGO;//StarGO prefab
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    public int MaxStars;

    Color[] starColors =
    {
        new Color(0.5f, 0.5f, 1f),//blue
        new Color(0, 1f, 1f),//green
        new Color(1f, 1f, 0),//yellow
        new Color(1f, 0, 0),//red
    };

<<<<<<< HEAD
=======
	// Use this for initialization
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Start () {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        for (int i = 0; i < MaxStars; ++i) {
            GameObject star = (GameObject)Instantiate(StarGO);

            star.GetComponent<SpriteRenderer>().color = starColors[i % starColors.Length];

            star.transform.position = new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));

<<<<<<< HEAD
            //Velocidade da estrela
            star.GetComponent<Star>().speed = -(1f * Random.value + 0.5f);

=======
            //set random speed of the star
            star.GetComponent<Star>().speed = -(1f * Random.value + 0.5f);

            //make the star a child of the StarGenerator
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
            star.transform.parent = transform;
        }
    }
	
<<<<<<< HEAD
=======
	// Update is called once per frame
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Update () {
	
	}
}
