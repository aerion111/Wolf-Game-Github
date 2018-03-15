using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour {

    public GameObject targetCorpse; // What to replace the wolf, or other target, with on hit.
    public int targetValue; // How many points you get for shooting the target.
    public playerController manager; // Change this to public PointsManager, or such, if you separate it out later.

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") // Should probably have used lowercase, but I didn't when making the tag so I can't do so here.
        {
            Destroy(other.gameObject); // Destroy the bullet - mostly because it was in the code given by the teacher, but we might as well.
            Instantiate(targetCorpse, transform.position, transform.rotation); // Spawn the corpse.
            // Do any special effect stuff, like blood-splatter or such. We should do SOMETHING, it feels underwhelming at the moment.
            print("Wolf hit, worth " + targetValue); // Debug stuff.
            manager.AddPoints(targetValue);
            Destroy(this.gameObject); // Finish by destroying the 'live' enemy/Target.
        }
    }
}