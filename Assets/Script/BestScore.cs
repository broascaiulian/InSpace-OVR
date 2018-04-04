using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    public static int HighScoreKmEasy;
    public static int HighScoreDistEasy;
    public static int HighScoreKmMedium;
    public static int HighScoreDistMedium;
    public static int HighScoreKmHard;
    public static int HighScoreDistHard;

    public static int HighScoreKmController;
    public static int HighScoreDistController;

    public static int HighScoreKmGear;
    public static int HighScoreDistGear;

    public static int Coin;

    public Text BestScor;
    public Text Coins;

    // Use this for initialization
    void Start () {
        HighScoreKmEasy = PlayerPrefs.GetInt("HighScoreKmEasy", HighScoreKmEasy);
        HighScoreDistEasy = PlayerPrefs.GetInt("HighScoreDistEasy", HighScoreKmEasy);
        HighScoreKmMedium = PlayerPrefs.GetInt("HighScoreKmMedium", HighScoreKmMedium);
        HighScoreDistMedium = PlayerPrefs.GetInt("HighScoreDistMedium", HighScoreKmMedium);
        HighScoreKmHard = PlayerPrefs.GetInt("HighScoreKmHard", HighScoreKmHard);
        HighScoreDistHard = PlayerPrefs.GetInt("HighScoreDistHard", HighScoreKmHard);
        HighScoreKmController = PlayerPrefs.GetInt("HighScoreKmController", HighScoreKmController);
        HighScoreDistController = PlayerPrefs.GetInt("HighScoreDistController", HighScoreDistController);
        HighScoreKmGear = PlayerPrefs.GetInt("HighScoreKmGear", HighScoreKmGear);
        HighScoreDistGear = PlayerPrefs.GetInt("HighScoreDistGear", HighScoreDistGear);

        Coin = PlayerPrefs.GetInt("Coins", Coin);
        Coins.text = "Coins:" + Coin;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DEasy()
    {
        BestScor.text = "Best Score Easy:" + HighScoreKmEasy + "." + HighScoreDistEasy + "Km";
    }
    public void DMed()
    {
        BestScor.text = "Best Score Medium:" + HighScoreKmMedium + "." + HighScoreDistMedium + "Km";
    }
    public void DHard()
    {
        BestScor.text = "Best Score Hard:" + HighScoreKmHard + "." + HighScoreDistHard + "Km";
    }
    public void DController()
    {
        BestScor.text = "Best Score Gear VR Controller:" + HighScoreKmController + "." + HighScoreDistController + "Km";
    }
    public void DGear()
    {
        BestScor.text = "Best Score Gear VR Touchpad:" + HighScoreKmGear + "." + HighScoreDistGear + "Km";
    }
    public void zero()
    {
        BestScor.text = "";
    }
}
