using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauzeMenu : MonoBehaviour {
	public static bool GameISPaused = false;
	public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		{
		
			if (GameISPaused) 
			{
				Resume();
			} 
			else 
			{
				Pause();
			}

		}
	}
	public void Resume ()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameISPaused = false;
	}
	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameISPaused = true;
	}
	public void LoadMenu()
	{
		Time.timeScale = 1f;
		Debug.Log("Loading Menu");
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
	}
	public void QuitGame()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
