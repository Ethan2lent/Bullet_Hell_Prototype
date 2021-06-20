using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
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
        other.gameObject.GetComponent<PlayerController>().isDead = true;
    }
    if (other.tag == "PlayerBullet2")
    {
        Destroy(gameObject);
    }
}
}
