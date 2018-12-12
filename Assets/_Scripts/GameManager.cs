using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    //Refrencias para os objetos usados no jogo
    public GameObject playButton;
    public GameObject playerShip;
    public GameObject enemySpawner;//Respawn inimigo
    public GameObject GameOverGO;//Gamer Over
    public GameObject scoreUITextGO;//Score texto
	public GameObject TimeCounterGO;//Tempo
	public GameObject GameTitleGO;//Titulo

	public enum GameManagerState
    {
        Opening,
        Gameplay,
        GameOver,
    }

    GameManagerState GMState;

	// Inicialização
	void Start () {
        GMState = GameManagerState.Opening;
    }
	
	//Atualiza o estado da UI do jogo
    void UpdateGameManagerState()
    {
        switch(GMState)
        {
            case GameManagerState.Opening:

                //Esconder o game over
                GameOverGO.SetActive(false);

				//Mostrar o titulo do jogo
				GameTitleGO.SetActive(true);

                //Mostrar o botao de play
                playButton.SetActive(true);

                break;
            case GameManagerState.Gameplay:

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
				TimeCounterGO.GetComponent<TimeCounter>().StartTimeCounter();

                break;
            case GameManagerState.GameOver:
				
				//Parar a contagem do tempo
				TimeCounterGO.GetComponent<TimeCounter>().StopTimeCounter();

                //Parar o respawn inimigo
                enemySpawner.GetComponent<EnemySpawner>().UnscheduleEnemySpawning();

                //Mostrar o game over
                GameOverGO.SetActive(true);

                //Muda o estado da UI para o inicio do game
                Invoke("ChangeToOpeningState", 8f);

                break;

        }
    }

    //Função para mudar o status do menu
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

    public void ChangeToOpeningState()
    {
        SetGameManagerState(GameManagerState.Opening);
    }
}
