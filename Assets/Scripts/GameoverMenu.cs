using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverMenu : MonoBehaviour
{
    public string mainMenuescene;

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuescene);
    }
}
