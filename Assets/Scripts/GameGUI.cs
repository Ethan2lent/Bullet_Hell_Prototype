using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGUI : MonoBehaviour
{
 public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

public void Controls()
    {
        SceneManager.LoadScene(2);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
