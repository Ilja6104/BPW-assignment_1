using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour {

	void Update()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

	}

	public void playGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void quitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();

	}

}
