using UnityEngine;
using System.Collections;
using System.Collections.Generic;//For Queue

public class PlanetController : MonoBehaviour {

    public GameObject[] Planets; //array dos Planetas 

    Queue<GameObject> availablePlanets = new Queue<GameObject>();


	// Inicialização
	void Start () {
        //adicionados os planetas as filas
        availablePlanets.Enqueue(Planets[0]);
        availablePlanets.Enqueue(Planets[1]);
        availablePlanets.Enqueue(Planets[2]);
        availablePlanets.Enqueue(Planets[3]);
        availablePlanets.Enqueue(Planets[4]);

        //chamando um planeta a cada 20 sec
        InvokeRepeating("MovePlanetDown", 0, 20f);
    }
	
	void Update () {
	
	}

    //Movendo o planeta
    void MovePlanetDown()
    {
        EnqueuePlanets();

        if(availablePlanets.Count == 0)
        {
            return;
        }

        GameObject aPlanet = availablePlanets.Dequeue();

        aPlanet.GetComponent<Planet>().isMoving = true;
    }

    void EnqueuePlanets()
    {
        foreach(GameObject aPlanet in Planets)
        {
            //Se o planeta esiver abaixo e nao estiver se movendo
            if((aPlanet.transform.position.y < 0) && (!aPlanet.GetComponent<Planet>().isMoving))
            {
                //Resetar o planeta para a posição padrão
                aPlanet.GetComponent<Planet>().ResetPosition();
                
                availablePlanets.Enqueue(aPlanet);
            }
        }
    }
}
