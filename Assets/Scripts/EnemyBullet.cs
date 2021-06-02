using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    private void Start()
    {
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
            other.gameObject.GetComponent<PlayerController>().isDead = true;
        }
    }
}


