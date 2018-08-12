using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGameUI : MonoBehaviour {

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        shooterScript.bulletCount = 10;
    }
    public void playAgain()
    {
        SceneManager.LoadScene(1);

    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
