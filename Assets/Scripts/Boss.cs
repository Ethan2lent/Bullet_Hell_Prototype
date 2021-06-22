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
    // Start is called before the first frame update
    void Start()
    {
        health = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * rotationSpeed);

        stayPosition = GameObject.FindGameObjectWithTag("Stop").transform;
        target = stayPosition.position;
        transform.position = Vector3.MoveTowards(transform.position, target, rotationSpeed * Time.deltaTime);

        if (health <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
    
}
