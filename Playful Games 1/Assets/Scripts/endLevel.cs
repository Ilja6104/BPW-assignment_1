using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour {

	private void OnTriggerEnter()
	{
        SceneManager.LoadScene(3);

    }
		
}
