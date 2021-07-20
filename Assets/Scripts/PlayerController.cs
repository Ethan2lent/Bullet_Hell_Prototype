using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;

    public int lives;

    [HideInInspector]
    public bool isDead;

    private Vector3 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        lives = 5;
    }

    void Update()
    {

        //WIll stop the player and move to the restart scene if lives reaches 0
        if (lives != 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                    transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            } 
        }
        else if (lives == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
        if(transform.position.x >= 2.2f)
        {
            transform.position = new Vector3(2.2f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -9f)
        {
            transform.position = new Vector3(-9f, transform.position.y, transform.position.z);
        }

        if (transform.position.z >= 5.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 5.1f);
        }
        else if (transform.position.z <= -5.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5.1f);
        }
    }
}
