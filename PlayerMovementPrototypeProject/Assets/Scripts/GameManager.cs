using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject combatMenu;
    public GameObject pendingMenu;
    public GameObject winMenu;
    public GameObject loseMenu;
    public GameObject drawMenu;

    public int playerChoice;
    public int botChoice;
    public int result = 3;

    public void OnStartButton()
    {
        startMenu.SetActive(false);
        combatMenu.SetActive(true);
    }

    public void OnRockButton()
    {
        playerChoice = 1;
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        Invoke("Results", 3.0f);
        BotAttack();
    }
    public void OnPaperButton()
    {
        playerChoice = 2;
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        Invoke("Results", 3.0f);
        BotAttack();
    }
    public void OnScissorsButton()
    {
        playerChoice = 3;
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        Invoke("Results", 3.0f);
        BotAttack();
    }

    public void BotAttack()
    {
        botChoice = Random.Range(1, 4);
        Debug.Log(botChoice);
        CheckResults();
    }

    public void CheckResults()
    {
        if(playerChoice == 1 && botChoice == 3 || playerChoice == 2 && botChoice == 1 || playerChoice == 3 && botChoice == 2)
        {
            result = 1;
        } else if(playerChoice == 3 && botChoice == 1 || playerChoice == 1 && botChoice == 2 || playerChoice == 2 && botChoice == 3)
        {
            result = 0;
        } else
        {
            result = 2;
        }
    }

    public void Results()
    {
        pendingMenu.SetActive(false);
        if(result == 0)
        {
            loseMenu.SetActive(true);

        } else if(result == 1)
        {
            winMenu.SetActive(true);
        } else if(result == 2)
        {
            drawMenu.SetActive(true);
        }
    }

    public void OnResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
