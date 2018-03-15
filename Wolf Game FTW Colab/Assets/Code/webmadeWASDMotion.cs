using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Not mine in any way, but I came across this as part of re-building the playerMotion the teacher showed me.
// This works fine - though obviously we'd want to adjust the speed - so if we ever want to change to/experiment with rotating with WASD, this is most of the work already done.
// I'd just keep it in my private notes, but I guess I can throw it in here in case Christina and/or a teacher wants to use it - to compare to our motion script, for example.
public class webmadeWASDMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
