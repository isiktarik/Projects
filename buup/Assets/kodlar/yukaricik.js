#pragma strict

function Start () {
	
}

function Update () {
	  
		if (Input.GetKey ("up")) {

			transform.position.y +=10.0*Time.deltaTime;
		}
}
