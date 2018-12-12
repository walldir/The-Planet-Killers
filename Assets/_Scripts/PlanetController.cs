using UnityEngine;
using System.Collections;
using System.Collections.Generic;//For Queue

public class PlanetController : MonoBehaviour {

<<<<<<< HEAD
    public GameObject[] Planets; //array dos Planetas 

    Queue<GameObject> availablePlanets = new Queue<GameObject>();


	// Inicialização
	void Start () {
        //adicionados os planetas as filas
=======
    public GameObject[] Planets; //array of PlanetGO prefabs

    //Queue to hold the planets
    Queue<GameObject> availablePlanets = new Queue<GameObject>();


	// Use this for initialization
	void Start () {
        //add the planets to the Queue
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
        availablePlanets.Enqueue(Planets[0]);
        availablePlanets.Enqueue(Planets[1]);
        availablePlanets.Enqueue(Planets[2]);
        availablePlanets.Enqueue(Planets[3]);
        availablePlanets.Enqueue(Planets[4]);

<<<<<<< HEAD
        //chamando um planeta a cada 20 sec
        InvokeRepeating("MovePlanetDown", 0, 20f);
    }
	
=======
        //call the MovePlanetDown function every 20 seconds
        InvokeRepeating("MovePlanetDown", 0, 20f);
    }
	
	// Update is called once per frame
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Update () {
	
	}

<<<<<<< HEAD
    //Movendo o planeta
=======
    //Dequeue the planet, and set its Moving flag to true so then the planet starts scrolling down the screen
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    void MovePlanetDown()
    {
        EnqueuePlanets();

        if(availablePlanets.Count == 0)
        {
            return;
        }

<<<<<<< HEAD
        GameObject aPlanet = availablePlanets.Dequeue();

        aPlanet.GetComponent<Planet>().isMoving = true;
    }

=======
        //Get the planet from the queue
        GameObject aPlanet = availablePlanets.Dequeue();

        //Set the planet isMoving flag to true
        aPlanet.GetComponent<Planet>().isMoving = true;
    }

    //Function to Enqueue planets that are below the screen and are not moving
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    void EnqueuePlanets()
    {
        foreach(GameObject aPlanet in Planets)
        {
<<<<<<< HEAD
            //Se o planeta esiver abaixo e nao estiver se movendo
            if((aPlanet.transform.position.y < 0) && (!aPlanet.GetComponent<Planet>().isMoving))
            {
                //Resetar o planeta para a posição padrão
                aPlanet.GetComponent<Planet>().ResetPosition();
                
=======
            //if the planet is below the screen and is not moving
            if((aPlanet.transform.position.y < 0) && (!aPlanet.GetComponent<Planet>().isMoving))
            {
                //reset the planet position
                aPlanet.GetComponent<Planet>().ResetPosition();

                //Enqueue the planet
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
                availablePlanets.Enqueue(aPlanet);
            }
        }
    }
}
