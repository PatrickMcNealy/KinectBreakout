using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public void RetryBtn()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
