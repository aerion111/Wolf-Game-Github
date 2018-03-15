
var menuCam : GameObject;

var playerCam : GameObject;

var manman : GameObject;
var submanman : GameObject; // Having trouble targeting the motion controls seperately from the rotation.

private var scripty : Component;
private var scriptx : Component;

function Start(){
	scripty = submanman.GetComponent("playerRotate");
	scriptx = manman.GetComponent("playerMotion");
	scripty.enabled = false;
	scriptx.enabled = false;
}

function OnMouseOver(){
	if (Input.GetMouseButtonUp(0)){
		menuCam.SetActive(false);
		playerCam.SetActive(true);
		scripty.enabled = true;
		scriptx.enabled = true;
	}
}