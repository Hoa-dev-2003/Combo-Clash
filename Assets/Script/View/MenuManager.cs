using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public UIManager uiManager;
    public void ButtonHeros()
    {
        GameManager.Instance.UpdateGameState(GameState.Heros);
    }

    public void ButtonWeapon()
    {
        GameManager.Instance.UpdateGameState(GameState.Weapons);
    }

    public void ButtonMenu()
    {
        GameManager.Instance.UpdateGameState(GameState.Menu);
    }

    public void ButtonShop()
    {
        GameManager.Instance.UpdateGameState(GameState.Shop);
    }

    public void ButtonSetting()
    {
        GameManager.Instance.UpdateGameState(GameState.Setting);
    }

    public void ButtonPlaying()
    {
        GameManager.Instance.UpdateGameState(GameState.Playing);
    }

    public void ButtonPause()
    {
        GameManager.Instance.UpdateGameState(GameState.Paused);
    }

    public void ButtonDeckHeros()
    {
        uiManager.ClickDeckHeros();
    }

    public void ButtonSkillHeros()
    {
        uiManager.ClickSkillHeros();
    }

    public void ButtonExit()
    {
        uiManager.ClickExitHeros();
    }

    public void ButtonWeaponUpgrade()
    {
        uiManager.SwitchWeaponMenu(0);
    }
    public void ButtonEvolveUpgrade()
    {
        uiManager.SwitchWeaponMenu(1);
    }
    
}
