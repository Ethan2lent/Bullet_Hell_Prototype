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
        if (targetPlayer == true) { 
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;

        target = playerPosition.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(target);
        transform.rotation = rotation;
        }
        Destroy(gameObject, lifeTime);
    }


    // Update is called once per frame
    void Update()
    {   
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead");
            other.GetComponent<PlayerController>().lives -= 1;
            Destroy(gameObject);
        }
        if (other.tag == "KillZone")
        {
            Destroy(gameObject);
        }
    }
}


