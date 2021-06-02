using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireRate : MonoBehaviour
{
    public GameObject projectileObject;

    public float enemyRefireRate;
    private float timePassed;
    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        timePassed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot == true)
        {
            Shoot();
            canShoot = false;
            timePassed = 0.0f;
        }


        timePassed += Time.deltaTime;

        if (timePassed >= enemyRefireRate)
        {
            canShoot = true;
        }
    }
    private void Shoot()
    {
        Instantiate(projectileObject, transform.position, transform.rotation);
    }
}
