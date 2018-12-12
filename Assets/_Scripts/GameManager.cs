using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

<<<<<<< HEAD
    //Refrencias para os objetos usados no jogo
    public GameObject playButton;
    public GameObject playerShip;
    public GameObject enemySpawner;//Respawn inimigo
    public GameObject GameOverGO;//Gamer Over
    public GameObject scoreUITextGO;//Score texto
	public GameObject TimeCounterGO;//Tempo
	public GameObject GameTitleGO;//Titulo
=======
    //Reference to our game objects
    public GameObject playButton;
    public GameObject playerShip;
    public GameObject enemySpawner;//reference to enemy spawner
    public GameObject GameOverGO;//reference to game over bg
    public GameObject scoreUITextGO;//reference to the score text UI game object
	public GameObject TimeCounterGO;//reference to the time counter game object
	public GameObject GameTitleGO;//reference to the GameTitleGO
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108

	public enum GameManagerState
    {
        Opening,
        Gameplay,
        GameOver,
    }

    GameManagerState GMState;

<<<<<<< HEAD
	// Inicialização
=======
	// Use this for initialization
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	void Start () {
        GMState = GameManagerState.Opening;
    }
	
<<<<<<< HEAD
	//Atualiza o estado da UI do jogo
=======
	//Function to update the game manager state
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    void UpdateGameManagerState()
    {
        switch(GMState)
        {
            case GameManagerState.Opening:

<<<<<<< HEAD
                //Esconder o game over
                GameOverGO.SetActive(false);

				//Mostrar o titulo do jogo
				GameTitleGO.SetActive(true);

                //Mostrar o botao de play
=======
                //Hide game over
                GameOverGO.SetActive(false);

				//Display the game title
				GameTitleGO.SetActive(true);

                //Set play button visible
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
                playButton.SetActive(true);

                break;
            case GameManagerState.Gameplay:

<<<<<<< HEAD
                //Resetar o score 
                scoreUITextGO.GetComponent<GameScore>().Score = 0;

                //Esconder o titulo do jogo
                playButton.SetActive(false);

				//Esconder o titulo do jogo
				GameTitleGO.SetActive(false);
            
                //Mostrar a nave e iniciar o jogo.
                playerShip.GetComponent<PlayerControl>().Init();

                //Inicar o respawn inimigo
                enemySpawner.GetComponent<EnemySpawner>().ScheduleEnemySpawner();

				//Começar a contagem do tempo
=======
                //Reset the score
                scoreUITextGO.GetComponent<GameScore>().Score = 0;

                //hide play button on game play state
                playButton.SetActive(false);

				//Hide the game title
				GameTitleGO.SetActive(false);

                //set the player visible and init the player
                playerShip.GetComponent<PlayerControl>().Init();

                //Start enemy spawner
                enemySpawner.GetComponent<EnemySpawner>().ScheduleEnemySpawner();

				//start the time counter
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
				TimeCounterGO.GetComponent<TimeCounter>().StartTimeCounter();

                break;
            case GameManagerState.GameOver:
				
<<<<<<< HEAD
				//Parar a contagem do tempo
				TimeCounterGO.GetComponent<TimeCounter>().StopTimeCounter();

                //Parar o respawn inimigo
                enemySpawner.GetComponent<EnemySpawner>().UnscheduleEnemySpawning();

                //Mostrar o game over
                GameOverGO.SetActive(true);

                //Muda o estado da UI para o inicio do game
=======
				//stop the time counter
				TimeCounterGO.GetComponent<TimeCounter>().StopTimeCounter();

                //Stop enemy spawning
                enemySpawner.GetComponent<EnemySpawner>().UnscheduleEnemySpawning();

                //Display game over
                GameOverGO.SetActive(true);

                //Change game manager state to Opening state
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
                Invoke("ChangeToOpeningState", 8f);

                break;

        }
    }

<<<<<<< HEAD
    //Função para mudar o status do menu
=======
    //Function to set the game manager state
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    public void SetGameManagerState(GameManagerState state)
    {
        GMState = state;
        UpdateGameManagerState();
    }

    public void StartGamePlay()
    {
        GMState = GameManagerState.Gameplay;
        UpdateGameManagerState();
    }

<<<<<<< HEAD
=======
    //Change game manager state to opening
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
    public void ChangeToOpeningState()
    {
        SetGameManagerState(GameManagerState.Opening);
    }
}
