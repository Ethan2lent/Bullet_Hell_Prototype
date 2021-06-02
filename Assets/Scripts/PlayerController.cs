using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;

    [HideInInspector]
    public bool isDead;


    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }
}
