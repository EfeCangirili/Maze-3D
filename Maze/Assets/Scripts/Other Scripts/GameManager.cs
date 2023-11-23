using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private Player playerScript;
    public GameObject completeLevelUI;
    private float restartDelay = .25f;
    private bool gameEnded = false;
    private void Awake()
    {
        playerScript = Player.Instance;
    }

    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("You Succeded");
    }

    public void GameFailed()
    {
        playerScript.enabled = false;
        if(!gameEnded)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        gameEnded = false;
        playerScript.RestartPosition();
    }
}
