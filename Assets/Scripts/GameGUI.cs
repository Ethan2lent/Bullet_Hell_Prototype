using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGUI : MonoBehaviour
{
    // Handles the scene management for GUI
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
