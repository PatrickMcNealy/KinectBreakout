using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCounter : MonoBehaviour
{

    [SerializeField]
    private GameObject[] lifeMarkers;

    [SerializeField]
    private int _lives;
    public int lives { get { return _lives; } }

    [SerializeField]
    GameObject gameOverMenu;

    public void LoseLife()
    {
        _lives--;

        if (lives == 1)
        {
            lifeMarkers[1].SetActive(false);
        }
        else if (lives == 0)
        {
            lifeMarkers[0].SetActive(false);
        }
        else if (lives == -1)
        {
            gameOverMenu.SetActive(true);
        }
    }

}
