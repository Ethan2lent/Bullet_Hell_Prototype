using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    void Update()
    {
        //Will control its movement
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
            Destroy(gameObject);
        }
        // Will be destroyed and the player will be rewarded 
    if (other.tag == "PlayerBullet2")
    {
                Scoring.score += 1;
            Destroy(gameObject);
    }
    //Will kill the object upon touch
        if (other.tag == "KillZone")
        {
            Destroy(gameObject);
        }
    }
}
