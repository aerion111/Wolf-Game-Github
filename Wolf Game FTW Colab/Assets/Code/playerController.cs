using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    // There isn't much point to seperate this from playerMovement, but I did Movement before this. 
    // On the upside, this keeps the scripts shorter, but it might be a problem later on - and does mean having to guess what code I put where.

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) // I'll change it to left click, probably, but I'm sticking to the guide for now.
        {
            Fire();
        }
    }

    // Firing the gun
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet. Originally involved a direct velocity definition, but it didn't work well and only that one tutorial used it. Everything else said to use AddForce.
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);

        // Destroy the bullet after 3 seconds
        Destroy(bullet, 3.0f);
    }
}