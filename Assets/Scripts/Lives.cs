using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int lifeCounter;
    public GameObject player;

    void Update()
    {
        //Will display the amount of lives the player has
        lifeCounter = player.GetComponent<PlayerController>().lives;
        gameObject.GetComponent<Text>().text = lifeCounter.ToString();
    }
}
