using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Might call it something else, if there's something more suitable for being called 'playerMotion', but this seems the most playerMotion-like script I've currently got intented.
// playerAI or such would also work, I guess.
public class playerMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Not sure I need anything here. Most things should probably be defined outside of this, as I defined a lot of stuff here in TD and then had problems down the road. Maybe if we want stuff that 'resets' properly to their defaults.
	}
	
	// Update is called once per frame
	void Update () {
        // Was going to do the rotation here, but actually, makes more sense to keep it seperate. I think.

    }

    // FixedUpdate, if I've done it right, is called once per 'tick'; It's Update, scaled to the speed of the engine, which in particular means slowing down when there's lag.
    void FixedUpdate()
    {
        // Currently, diagonal movement is 'full' speed; Considering doing a lot of if/elseif 'branches' (they're hardly 'trees' at that size) to 'fix' this, but I'm hoping there'll be a better option.
        // In particular, I want to 'complicate' the code more, but it's taking too long, so I'm leaving it as is.
        // If I don't have a new approach that inherently solves the diagonal issue by the time I need it working right, I can try to hobble a makeshift solution together (I really do not like else-if trees when they're not needed)

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }

    }
}
