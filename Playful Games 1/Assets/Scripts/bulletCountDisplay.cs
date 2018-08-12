using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletCountDisplay : MonoBehaviour {
	private TextMeshProUGUI textMesh;

	private int getBulletCount;

	void Start () {

		textMesh = gameObject.GetComponent<TextMeshProUGUI> ();

	}


	void Update () {
		getBulletCount = shooterScript.bulletCount;

		textMesh.text = getBulletCount.ToString ();

	}
		
}
