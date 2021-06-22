using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRate : MonoBehaviour
{
    public GameObject projectileObjectEnemy;
    public GameObject projectileObjectObstacle;

    public float refireRateEnemy;
    public float refireRateObstacle;
    private float timePassed;
    private bool gunMode;
    private bool canShoot;

    void Start()
    {
        gunMode = true;
        canShoot = true;
        timePassed = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {   //Confirms if space is pressed and canshoot is true as well as what type of bullet is being shot
        if (Input.GetKeyDown(KeyCode.C))
            {
            gunMode = false;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            gunMode = true;
        }

        if (gunMode == true)
        { 
            if ((Input.GetKey(KeyCode.Z)) && (canShoot == true))
        {
            Shoot();
            canShoot = false;
            timePassed = 0.0f;
        }
            timePassed += Time.deltaTime;

            if (timePassed >= refireRateEnemy)
            {
                canShoot = true;
            }
        }

        if (gunMode == false)
        {
            if ((Input.GetKey(KeyCode.Z)) && (canShoot == true))
            {
                Shoot();
                canShoot = false;
                timePassed = 0.0f;
            }
            timePassed += Time.deltaTime;

            if (timePassed >= refireRateObstacle)
            {
                canShoot = true;
            }
        }


    }

    private void Shoot()
    {
        if (transform.root.GetComponent<PlayerController>().lives > 0)
        {
            //Change modes based on if the bool is true or false
            if (gunMode == true) {
            Instantiate(projectileObjectEnemy, transform.position, transform.rotation);
            }
            if (gunMode == false)
            {
                Instantiate(projectileObjectObstacle, transform.position, transform.rotation);
            }
        }
    }
}
