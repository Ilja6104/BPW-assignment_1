using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;

	

	public void Update () {
		
		if (doorIsOpening == true) {
			Door.transform.Translate (Vector3.up * Time.deltaTime * 3);
		}
		if (Door.transform.position.y > 5f) {
			doorIsOpening = false;
		}
	}

	public void ButtonClick(){
		doorIsOpening = true;

	}

}
