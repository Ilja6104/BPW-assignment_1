using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickerScript : MonoBehaviour {

	public float range = 10.0f;
	private void Update()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit, range)) 
			{
				if (hit.transform != null) 
				{
					PrintName (hit.transform.gameObject);
					//if (hit.transform.gameObject) == Button
				}

				DoorController targetButton = hit.transform.GetComponent<DoorController>();

				if (targetButton != null) 
				{
					targetButton.ButtonClick ();
				}

			}
			
		}
	

		
	}
	private void PrintName(GameObject go)
	{
		print (go.name);
	}
}

