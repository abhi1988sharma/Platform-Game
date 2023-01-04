using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public string gameCompletecene;

    public void Gamecomplete()
    {
        SceneManager.LoadScene(gameCompletecene);
    }
}
