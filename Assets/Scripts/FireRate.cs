using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRate : MonoBehaviour
{
    public GameObject projectileObject;

    public float refireRate;
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
    {   //Confirms if space is pressed and canshoot is true
  

            if ((Input.GetKey(KeyCode.Z)) && (canShoot == true))
        {
            Shoot();
            canShoot = false;
            timePassed = 0.0f;
        }



        timePassed += Time.deltaTime;

        if (timePassed >= refireRate)
        {
            canShoot = true;
        }

    }

    private void Shoot()
    {
        if (!transform.root.GetComponent<PlayerController>().isDead)
        {
            Instantiate(projectileObject, transform.position, transform.rotation);
        }
    }
}
