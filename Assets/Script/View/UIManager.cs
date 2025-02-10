using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
    [Header("Menu Game")]
    public GameObject menuGame;
    public RectTransform heros;

    public GameObject[] menuState;
    public GameObject gameSetting;

    [Header("Menu Heros")] 
    public GameObject deck;
    public GameObject skill;

    [Header("Menu Weapon")]
    public GameObject[] weaponMenu;

    [Header("Game Play")]
    public GameObject gamePlay;
    public GameObject gamePause;
    
    private void Start()
    {
        GameManager.OnGameStateChanged += UpdateGameState;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= UpdateGameState;
    }

    void UpdateGameState(GameState state)
    {
        switch (state)
        {
            case GameState.Heros :
                HandleHeros();
                break;
            case GameState.Weapons :
                HandleWeapon();
                break;
            case GameState.Menu :
                HandleMenu();
                break;
            case GameState.Shop :
                HandleShop();
                break;
            case GameState.Playing :
                HandlePlaying();
                break;
            case GameState.Setting :
                HandleSetting();
                break;
            case GameState.Paused:
                HandleGamePause();
                break;
            case GameState.GameEnd:
                HandleGameEnd();
                break;
        }
    }

    void HandleHeros()
    {
        Debug.Log("Heros");
        MenuSwitch(0);
    }

    void HandleWeapon()
    {
        Debug.Log("weapon");
        MenuSwitch(1);

    }

    void HandleMenu()
    {
        if (!gameSetting.activeInHierarchy)
        {
            menuGame.SetActive(true);
            gamePlay.SetActive(false);
            
            Debug.Log("menu");
            MenuSwitch(2);
        }
        else
        {
            gameSetting.SetActive(false);
            Debug.Log("Out Setting ");
        }
    }
    void HandleShop()
    {
        Debug.Log("shop");
        MenuSwitch(3);
    }

    void HandlePlaying()
    {
        if (menuGame.activeInHierarchy)
        {
            menuGame.SetActive(false);
            gamePlay.SetActive(true);
        }

        if (gamePlay.activeInHierarchy)
        {
            gamePause.SetActive(false);
        }
    }

    void HandleSetting()
    {
        gameSetting.SetActive(true);
    }

    void HandleGamePause()
    {
        gamePause.SetActive(true);
    }

    void HandleGameEnd()
    {
        
    }
    
    public void MenuSwitch(int type)
    {
        foreach (GameObject menu in menuState)
        {
            menu.SetActive(false);
        }
        menuState[type].SetActive(true);
    }

    #region Heros Click
    public void ClickDeckHeros()
    {
        deck.SetActive(true);
    }
    public void ClickSkillHeros()
    {
        skill.SetActive(true);
    }

    public void ClickExitHeros()
    {
        deck.SetActive(false);
        skill.SetActive(false);
    }
    #endregion

    #region WeaponClick
    public void SwitchWeaponMenu(int type)
    {
        foreach (GameObject weapon in weaponMenu)
        {
            weapon.SetActive(false);
        }
        weaponMenu[type].SetActive(true);
    }
    #endregion
}
