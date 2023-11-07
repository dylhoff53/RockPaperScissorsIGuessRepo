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
    public GameObject optionsMenu;

    public Text playerText;
    public Text botText;
    public Text playerTitle;
    public Text botTitle;
    public Text mainCombatText;
    public Text[] fadinTexts;


    public int playerChoice = 15;
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

    public void OnOptionsMenu()
    {
        optionsMenu.SetActive(true);
        startMenu.SetActive(false);
    }

    public void OnBackButton()
    {
        optionsMenu.SetActive(false);
        startMenu.SetActive(true);
    }
    public void OnStartButton()
    {
        startMenu.SetActive(false);
        combatMenu.SetActive(true);
    }

    public void OnRockButton()
    {
        playerChoice = 0;
        LeavingCombat();
    }
    public void OnPaperButton()
    {
        playerChoice = 8;
        LeavingCombat();
    }
    public void OnScissorsButton()
    {
        playerChoice = 2;
        LeavingCombat();
    }

    public void OnFireButton()
    {
        playerChoice = 1;
        LeavingCombat();
    }

    public void OnSnakeButton()
    {
        playerChoice = 3;
        LeavingCombat();
    }

    public void OnHumanButton()
    {
        playerChoice = 4;
        LeavingCombat();
    }

    public void OnTreeButton()
    {
        playerChoice = 5;
        LeavingCombat();
    }

    public void OnWolfButton()
    {
        playerChoice = 6;
        LeavingCombat();
    }

    public void OnSpongeButton()
    {
        playerChoice = 7;
        LeavingCombat();
    }

    public void OnAirButton()
    {
        playerChoice = 9;
        LeavingCombat();
    }

    public void OnWaterButton()
    {
        playerChoice = 10;
        LeavingCombat();
    }

    public void OnDragonButton()
    {
        playerChoice = 11;
        LeavingCombat();
    }

    public void OnDevilButton()
    {
        playerChoice = 12;
        LeavingCombat();
    }

    public void OnLightningButton()
    {
        playerChoice = 13;
        LeavingCombat();
    }

    public void OnGunButton()
    {
        playerChoice = 14;
        LeavingCombat();
    }

    public void LeavingCombat()
    {
        combatMenu.SetActive(false);
        pendingMenu.SetActive(true);
        FillText(playerChoice, playerText);
        BotAttack();
    }
    public void BotAttack()
    {
        botChoice = Random.Range(0, 15);
        Debug.Log(botChoice);
        FillText(botChoice, botText);
        CheckResults();
    }

    public void FillText(int choice, Text text)
    {
        if(choice == 0)
        {
            text.text = "Rock";
        } else if( choice == 1)
        {
            text.text = "Fire";
        } else if (choice == 2)
        {
            text.text = "Scissors";
        } else if (choice == 3)
        {
            text.text = "Snake";
        } else if (choice == 4)
        {
            text.text = "Human";
        } else if (choice == 5)
        {
            text.text = "Tree";
        } else if (choice == 6)
        {
            text.text = "Wolf";
        } else if (choice == 7)
        {
            text.text = "Sponge";
        } else if (choice == 8)
        {
            text.text = "Paper";
        } else if (choice == 9)
        {
            text.text = "Air";
        } else if (choice == 10)
        {
            text.text = "Water";
        } else if (choice == 11)
        {
            text.text = "Dragon";
        } else if (choice == 12)
        {
            text.text = "Devil";
        } else if (choice == 13)
        {
            text.text = "Lightning";
        } else if (choice == 14)
        {
            text.text = "Gun";
        }
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
        BeginResults();
       // Invoke("Results", 2.0f);
    }

    public void BeginResults()
    {
        StartCoroutine(FadeMusic());
        Invoke("ShowResults", 2f);
        Invoke("Results", 7f);
    }

    public void ShowResults()
    {
        mainCombatText.GetComponent<FadingStuff>().FadeOut();
    }

    IEnumerator FadeMusic()
    {
        foreach(Text text in fadinTexts)
        {
            text.GetComponent<FadingStuff>().StartFading();
            yield return new WaitForSeconds(1f);
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
