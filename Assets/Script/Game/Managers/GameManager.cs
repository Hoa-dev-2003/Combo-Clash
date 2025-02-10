using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    public static UnityAction<GameState> OnGameStateChanged;

    public GameState gameState;
    private GameState oldState;

    public bool isPlaying;
    public bool isWin;
    
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        UpdateGameState(GameState.Menu);
    }

    public void UpdateGameState(GameState newState, bool? _isWin = null)
    {
        if (oldState == newState)
        {
            Debug.Log("Da bang");
            return;
        }
        
        gameState = newState;

        if (_isWin.HasValue)
        {
            isWin = _isWin.Value;
        }

        switch (newState)
        {
            case GameState.Heros :
                break;
            case GameState.Weapons :
                break;
            case GameState.Menu :
                HandleMenu();
                break;
            case GameState.Shop :
                break;
            case GameState.Playing :
                break;
            case GameState.Setting :
                break;
            case GameState.Paused :
                break;
            case GameState.GameEnd:
                HandleGameEnd();
                break;
        }
        OnGameStateChanged?.Invoke(gameState);
        oldState = gameState;
    }

    void HandleMenu()
    {
        isWin = false;
    }

    void HandleGameEnd()
    {
        if (isWin)
        {
            Debug.Log("Game Success");

        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}

public enum GameState
{
    Heros,
    Weapons,
    Menu,
    Shop,
    Playing,
    Setting,
    Paused,
    GameEnd
}
