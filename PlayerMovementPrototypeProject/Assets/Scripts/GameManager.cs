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
    public int[] loop;
    public int count = 0;

    public void Awake()
    {
        loop = new int[15];
        for(int i = 0; i < 15; i++)
        {
            loop[i] = i;
        }
    }

    public void OnStartButton()
    {
        startMenu.SetActive(false);
        combatMenu.SetActive(true);
    }

    public void OnRockButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 0;
        BotAttack();
    }
    public void OnPaperButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 8;
        BotAttack();
    }
    public void OnScissorsButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 2;
        BotAttack();
    }

    public void OnFireButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 1;
        BotAttack();
    }

    public void OnSnakeButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 3;
        BotAttack();
    }

    public void OnHumanButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 4;
        BotAttack();
    }

    public void OnTreeButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 5;
        BotAttack();
    }

    public void OnWolfButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 6;
        BotAttack();
    }

    public void OnSpongeButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 7;
        BotAttack();
    }

    public void OnAirButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 9;
        BotAttack();
    }

    public void OnWaterButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 10;
        BotAttack();
    }

    public void OnDragonButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 11;
        BotAttack();
    }

    public void OnDevilButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 12;
        BotAttack();
    }

    public void OnLightningButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 13;
        BotAttack();
    }

    public void OnGunButton()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        playerChoice = 14;
        BotAttack();
    }
    public void BotAttack()
    {
        botChoice = Random.Range(0, 15);
        Debug.Log(botChoice);
        CheckResults();
    }

    public void CheckResults()
    {
        for(int i = 0; i < 8; i++)
        {
            if(i + playerChoice < 15)
            {
                if(i + playerChoice == botChoice && i == 0)
                {
                    result = 2;
                } else if(i + playerChoice == botChoice)
                {
                    result = 1;
                }
            }else
            {
                if (loop[count] == botChoice)
                {
                    result = 1;
                }
                count++;
            }
        }

        if(result == 3)
        {
            result = 0;
        }
        Invoke("Results", 2.0f);
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
