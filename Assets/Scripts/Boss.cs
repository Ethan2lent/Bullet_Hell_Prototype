using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    private Transform stayPosition;
    private Vector3 target;
    public float rotationSpeed;

    public int health;

    void Start()
    {
        health = 2000;
    }

    void Update()
    {
        //Will go to the set location and will constantly rotate
        transform.Rotate(transform.up * rotationSpeed);

        stayPosition = GameObject.FindGameObjectWithTag("Stop").transform;
        target = stayPosition.position;
        transform.position = Vector3.MoveTowards(transform.position, target, rotationSpeed * Time.deltaTime);

        //Will change scenes if health is 0
        if (health <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
    
}
