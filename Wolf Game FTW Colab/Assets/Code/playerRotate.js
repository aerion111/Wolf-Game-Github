#pragma strict
// Not actually 100% sure this needs to be seperate from playerMotion, but if I AM keeping it seperate I might as well do it in JS like the teacher.


function Start () {
	// print ("Start");
}

function Update () {
	var hit: RaycastHit;
    var ray: Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
     if(Physics.Raycast(ray, hit))
     {
		var targetPosition : Vector3 = Vector3(hit.point.x, transform.position.y, hit.point.z);
		// print ("Hit " + hit.point);
        transform.LookAt(targetPosition); // In my notes, I've specifically written 'not transform', and I vaguelly remember there being a problem with it, but this works fine. I've also written 'hit.point' in relation to that, so maybe 'transform' was used in the target too? I wish I'd taken better notes.
		// Trying to fix the weird movement.
     }
}
