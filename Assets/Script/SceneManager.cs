using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneManager : MonoBehaviour
{
    public GameObject[] Scenes;
    public GameObject endingScene;
    private int armorPoints = 10070;
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
        if (armorPoints <= 0)
        {
            endingScene.SetActive(true);
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
        activeScene++;
    }

    public void StartButton()
    {
        activeScene = 1;
    }

    public void RepairKit()
    {
        armorPoints += 2000;
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
}