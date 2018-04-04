using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DistancePctPlayerController : MonoBehaviour {

    public static int zero = 1;
    public Text BestScore;
    private float distance;
    private float distanceKM;
    public Text distanceText;
    private float dist;
    private int km;
    public static int HighScoreKmController;
    public static int HighScoreDistController;
    private int dist1;
    private int km1;
    // Use this for initialization
    void Start()
    {
        km = 0;
        //HighScoreKmController = PlayerPrefs.GetInt("HighScoreKmController", HighScoreKmController);
        //HighScoreDistController = PlayerPrefs.GetInt("HighScoreDistController", HighScoreDistController);
        searchBestLocalScore();
    }
    public void searchBestScore()
    {
            if (km > HighScoreKmController)
            {
                PlayerPrefs.SetInt("HighScoreKmController", km);
                PlayerPrefs.SetInt("HighScoreDistController", (int)dist);
            }
            else
                if (km == HighScoreKmController)
                    if (dist >= HighScoreDistController)
                        PlayerPrefs.SetInt("HighScoreDistController", (int)dist);
    }
    public void searchBestLocalScore()
    {
            //km1 = PlayerPrefs.GetInt("HighScoreKmController", km1);
            //dist1 = PlayerPrefs.GetInt("HighScoreDistController", (int)dist1);

            HighScoreKmController = PlayerPrefs.GetInt("HighScoreKmController", HighScoreKmController);
            HighScoreDistController = PlayerPrefs.GetInt("HighScoreDistController", HighScoreDistController);

            //if (HighScoreDistController >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistController", 0);
            //    //  PlayerPrefs.SetInt("HighScoreKmEasy", HighScoreKmEasy + 1);
            //}
            BestScore.text = "Best Score:" + HighScoreKmController + "." + HighScoreDistController + "Km";
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Time.deltaTime * 50f * MoveMapController.CyC * 1.5f);
        distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);

        //if (distance < 400)
        //{
        //    //print("Distance to other: " + (distanceKM + distance));
        //    dist = distance + distanceKM;
        //    distanceText.text = "Distance: " + km + "." + (int)dist + "Km";
        //    if (distance + distanceKM > 1000)
        //    {
        //        km++;
        //        distanceKM = 0;
        //        transform.position = new Vector3(0, 2, 12);
        //    }
        //}
        //else
        //{
        //    distanceKM += distance;
        //    transform.position = new Vector3(0, 2, 12);
        //}
        //searchBestScore();
        //searchBestLocalScore();
        //BestScore.text = "Best Score:" + km1 + "." + dist1 + "Km";

        if (distance < 1000)
        {
            //print("Distance to other: " + (distanceKM + distance));
            distanceText.text = "Distance: " + km + "." + (int)distance + "Km";
            dist = (int)distance;
        }
        else
        {
            distance = 0;
            km++;
            transform.position = new Vector3(0, 2, 12);
        }

        if (zero == 0)
        {
            searchBestScore();
            searchBestLocalScore();
            distance = 0;
            //distanceKM = 0;
            km = 0;
            dist = 0;
            transform.position = new Vector3(0, 2, 12);
            zero = 1;
        }
    }
}
