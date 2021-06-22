using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    public bool targetPlayer;

    private Transform playerPosition;
    private Vector3 target;

    private void Start()
    {
        //Option to target the player upon creation 
        if (targetPlayer == true) { 
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;

        target = playerPosition.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(target);
        transform.rotation = rotation;
        }
        Destroy(gameObject, lifeTime);
    }


    void Update()
    {   
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

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
        //Will kill the object upon touch
        if (other.tag == "KillZone")
        {
            Destroy(gameObject);
        }
    }
}


