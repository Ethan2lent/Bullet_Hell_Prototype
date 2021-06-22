using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int score = 0;

    void Update()
    {
        //Will display the score
        gameObject.GetComponent<Text>().text = score.ToString();
    }
}
