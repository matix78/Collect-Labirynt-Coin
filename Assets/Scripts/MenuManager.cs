using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject image;
    public GameObject ButtonContainer;
    public GameObject DevelopersList;
    public GameObject JuniorDevelopersList;
    public GameObject BetaTestersList;
    public GameObject infoBox;
    public int MaxLevelScene = 3;

    void Start()
    {
        image.SetActive(false);
        ButtonContainer.SetActive(true);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void PlayBtn()
    {
        int indexScene = Random.Range(1, MaxLevelScene);

        SceneManager.LoadScene(indexScene);
    }

    public void AutorsBtn()
    {
        image.SetActive(true);
        ButtonContainer.SetActive(false);
    }

    public void BackToMenu()
    {
        image.SetActive(false);
        ButtonContainer.SetActive(true);
        infoBox.SetActive(false);
        DevelopersList.SetActive(false);
        JuniorDevelopersList.SetActive(false);
        BetaTestersList.SetActive(false);
    }

    public void OpenDevelopers()
    {
        ButtonContainer.SetActive(false);
        DevelopersList.SetActive(true);
    }

    public void OpenJuniorDevelopers()
    {
        ButtonContainer.SetActive(false);
        JuniorDevelopersList.SetActive(true);
    }

    public void OpenBetaTestersList()
    {
        ButtonContainer.SetActive(false);
        BetaTestersList.SetActive(true);
    }

    public void BackToList()
    {
        image.SetActive(true);
        DevelopersList.SetActive(false);
        JuniorDevelopersList.SetActive(false);
        BetaTestersList.SetActive(false);
    }

    public void InfoBox()
    {
        ButtonContainer.SetActive(false);
        infoBox.SetActive(true);
    }

}
