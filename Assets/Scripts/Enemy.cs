using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

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
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead");
            other.GetComponent<PlayerController>().lives -= 1;
            Destroy(gameObject);
        }
        if (other.tag == "PlayerBullet1")
        {
            Scoring.score += 1;
            Destroy(gameObject);
        }
        if (other.tag == "KillZone")
        {
            Destroy(gameObject);
        }
    }
}
