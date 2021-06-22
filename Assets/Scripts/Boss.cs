using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Transform playerPosition;
    private Vector3 target;

    public float bossMoveTimer;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        bossMoveTimer += Time.deltaTime;
        transform.rotation = Quaternion(transform.position * rotationSpeed);

        if (bossMoveTimer % 4 == 0) { 
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        target = playerPosition.position - transform.position;
        }
    }
}
