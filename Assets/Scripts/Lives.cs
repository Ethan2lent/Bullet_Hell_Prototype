using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int lifeCounter;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        lifeCounter = player.GetComponent<PlayerController>().lives;
        gameObject.GetComponent<Text>().text = lifeCounter.ToString();
    }
}
