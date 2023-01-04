using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    
    public string gameoverscene;
    public AudioSource deathSound;
    
    private void FixedUpdate()
    {
        if(transform.position.y < -3)
        {
            Destroy(gameObject);
            deathSound.Play();
            GameoverScene(); 
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Destroy(gameObject);
            deathSound.Play();
            GameoverScene();
        }

    }

    public void GameoverScene()
    {
        SceneManager.LoadScene(gameoverscene);
    }

}
