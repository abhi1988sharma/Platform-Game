using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public string firstLevel;
    public GameObject optionScreen;

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);

    }

    public void OpenOptions()
    {
        optionScreen.SetActive(true);

    }

    public void CloseOptions()
    {
        optionScreen.SetActive(false);

    }

    public void Quit()
    {// quits the any open programme in unity
        Application.Quit(); 
    }
}
