using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Button[] buttons;
    public Button winSign;
    public Button loseSign;
    bool gameOver;

	// Use this for initialization
	void Start () {
        gameOver = false;
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gameOverActivated() {
        gameOver = true;
        Time.timeScale = 0;
        loseSign.gameObject.SetActive(true);
        foreach (Button button in buttons) {
            button.gameObject.SetActive(true);
        }
    }

    public void gameWonActivated()
    {
        gameOver = true;
        Time.timeScale = 0;
        winSign.gameObject.SetActive(true);
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void Play() {
        SceneManager.LoadScene("RacingL1");
    }

    public void Replay() {
        gameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
