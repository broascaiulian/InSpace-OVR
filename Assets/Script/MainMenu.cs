using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Back()
    {
        Application.LoadLevel(0);
    }
    public void StartGame()
    {
        Application.LoadLevel(1);
    }
    public void ResetScore()
    {
        PlayerPrefs.SetInt("HighScoreKmEasy", 0);
        PlayerPrefs.SetInt("HighScoreDistEasy", 0);

        PlayerPrefs.SetInt("HighScoreKmMedium", 0);
        PlayerPrefs.SetInt("HighScoreDistMedium", 0);

        PlayerPrefs.SetInt("HighScoreKmHard", 0);
        PlayerPrefs.SetInt("HighScoreDistHard", 0);

        PlayerPrefs.SetInt("HighScoreKmController", 0);
        PlayerPrefs.SetInt("HighScoreDistController", 0);

        PlayerPrefs.SetInt("HighScoreKmGear", 0);
        PlayerPrefs.SetInt("HighScoreDistGear", 0);

        PlayerPrefs.SetInt("Coins", 0);
    }
    public void Quit()
    {
        Application.Quit();
        //if() distance
    }
}
