using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour {
	private TextMeshProUGUI textMesh;

	public static float timeRemaining;



	void Start () {
		timeRemaining = 45;
		textMesh = gameObject.GetComponent<TextMeshProUGUI> ();

	}
	

	void Update () {
		
		timeRemaining -= 1 * Time.deltaTime;
		textMesh.text = timeRemaining.ToString ();

        if (timeRemaining <= 0)
        {
            SceneManager.LoadScene(2);
        }

	}


}
