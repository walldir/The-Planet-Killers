using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScore : MonoBehaviour {

    Text scoreTextUI;

    int score;

    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            this.score = value;
            UpdateScoreTextUI();
        }
    }

<<<<<<< HEAD
	// Inicialização
	void Start () {        
        //Pega o texto da UI para esse objeto
        scoreTextUI = GetComponent<Text>();
	}

    //Atualizar o score na UI
=======
	// Use this for initialization
	void Start () {
        //Get the Text UI component of this gameObject
        scoreTextUI = GetComponent<Text>();
	}

    //Update the score text UI
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    void UpdateScoreTextUI()
    {
        string scoreStr = string.Format("{0:0000000}", score);
        scoreTextUI.text = scoreStr;
    }
	
}
