using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManager : MonoBehaviour
{
    public GameObject[] Scenes;
    public int armorPoints = 10070;
    public int activeScene;
    public TextMeshProUGUI armorValue;
    public GameObject Stats;
    public bool managerRunning = true;

    void Start()
    {
        Scenes[0].SetActive(true);
        Stats.SetActive(false);
    }

    void Update()
    {
        armorValue.text = armorPoints.ToString();

        if (armorPoints > 10070)
        {
            armorPoints = 10070;
        }
        else if (armorPoints <= 0)
        {
            armorPoints = 0;
        }

        SceneChanger();
    }

    public void SceneChanger()
    {
        if(managerRunning == true)
        {
            for (int i = 0; i < Scenes.Length; i++)
            {
                Scenes[i].SetActive(i == activeScene);
            }
        }
        
    }

    public void NextScene()
    {
        if (armorPoints <= 0)
        {
            activeScene = 74;
            Stats.SetActive(false);
            armorPoints = 10070;
        }
        else
        {
            activeScene++;
        }
    }

    public void StartButton()
    {
        activeScene = 1;
    }

    public void RepairKit()
    {
        armorPoints += 6000;
    }

    public void ToggleStatsOn()
    {
        Stats.SetActive(true);
    }

    public void ToggleStatsOff()
    {
        Stats.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayerDamage50()
    {
        armorPoints -= 5035;
    }

    public void PlayerDamage20()
    {
        armorPoints -= 2014;
    }

    public void PlayerDamage10()
    {
        armorPoints -= 1007;
    }

    public void PlayerDamage5()
    {
        armorPoints -= 504;
    }

    public void PauseManager()
    {
        managerRunning = false;
    }

    public void ResumeManager()
    {
        managerRunning = true;
    }
    
    public void ReturnToMenu()
    {
        activeScene = 0;
    }

    public void ResetAP()
    {
        armorPoints = 10070;
    }
}