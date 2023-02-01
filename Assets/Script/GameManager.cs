using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    protected GameManager() { }
    private static GameManager instance;

    private GameState _currentGameState;
    public GameState CurrentGameState
    {
        get { return _currentGameState; }
        set { _currentGameState = value; }
    }


    public static GameManager Instance
    {
        get
        {
            if (GameManager.instance == null)
            {
                GameManager.instance = new GameManager();
                DontDestroyOnLoad(GameManager.instance);
            }

            return GameManager.instance;
        }
    }
}

public enum GameState
{
    Start,
    End
}
