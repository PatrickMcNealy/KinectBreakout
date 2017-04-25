using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{

    [SerializeField]
    GameObject[] bricks;

    private void ResetBricks()
    {
        for(int i = 0; i<bricks.Length; i++)
        {
            bricks[i].SetActive(true);
        }
    }

    public void checkReset()
    {
        for (int i = 0; i < bricks.Length; i++)
        {
            if(bricks[i].activeSelf == true)
            {
                return;
            }
        }

        ResetBricks();
    }

}
