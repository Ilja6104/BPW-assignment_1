using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGameUI : MonoBehaviour {

    public void playAgain()
    {
        SceneManager.LoadScene(1);

    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
