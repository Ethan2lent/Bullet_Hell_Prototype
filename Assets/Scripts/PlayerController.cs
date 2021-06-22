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


    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
