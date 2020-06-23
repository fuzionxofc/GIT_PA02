using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager thismanager;
    public enum GameState {  GameOver, GameStart, GameIdle};
    public static GameState CurrentState = GameState.GameIdle;

    public static int Lives = 3;
    public static int Score = 0;

    void Start()
    {
        thismanager = this;
        Lives = 3;
        Score = 0;
        Time.timeScale = 0;
        CurrentState = GameState.GameIdle;
    }
    
    void Update()
    {
        if(Lives <= 0)
        {
            HUD.HUDManager.GameOver();
        }
        if(CurrentState == GameState.GameIdle && Input.GetKeyDown(KeyCode.Return))
        {            
            CurrentState = GameState.GameStart;
            Time.timeScale = 1;
            HUD.HUDManager.DismissMessage();
        }

        else if(CurrentState == GameState.GameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void updatehealth()
    {
        Lives--;
        HUD.HUDManager.UpdateLives();
    }
    public void updatescore()
    {
        Score++;
        HUD.HUDManager.UpdateScore();
    }
}
