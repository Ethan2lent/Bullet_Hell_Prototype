using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameObject soundObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Will kill itself and deduct a life from the player
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead");
            other.GetComponent<PlayerController>().lives -= 1;
            Spawn();
            Destroy(gameObject);
        }
        // Will be destroyed and the player will be rewarded 
        if (other.tag == "PlayerBullet1")
        {
            Scoring.score += 1;
            Spawn();
            Destroy(gameObject);
        }
        //Will kill the object upon touch
        if (other.tag == "KillZone")
        {
            Destroy(gameObject);
        }
    }
    private void Spawn()
    {
        Instantiate(soundObject);
    }
}
