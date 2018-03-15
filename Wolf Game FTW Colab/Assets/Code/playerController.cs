using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    // There isn't much point to seperate this from playerMovement, but I did Movement before this. 
    // On the upside, this keeps the scripts shorter, but it might be a problem later on - and does mean having to guess what code I put where.

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public string scoreText; // They were using 'Text' instead of string here, but it gave an error.

    private int Points;

    // Use this for initialization
    void Start () {
        Points = 0;
        scoreText = "score:" + Points; // When using Text before, they used .text here.
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

    public void AddPoints(int amount) // This might get moved to a score-screen script instead, but for now this is the most intuitive of the currently-existing places for it.
    {
        Points = Points + amount;
        scoreText = "score:" + Points;
        print("Score:" + Points); // No score screen yet, so just throwing it into the log instead.
    }
}