using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistancePctPlayerAcc : MonoBehaviour {

    public static int zero=1;
    private float distance;
    private float distanceKM;
    public Text distanceText;
    public Text BestScore;
    private float dista;
    private int dist;
    private int km;
    private int dist1;
    private int km1;
    public static int HighScoreKmEasy;
    public static int HighScoreDistEasy;
    public static int HighScoreKmMedium;
    public static int HighScoreDistMedium;
    public static int HighScoreKmHard;
    public static int HighScoreDistHard;
    // public Transform other;
    // Use this for initialization
    void Start()
    {
        km = 0;
        //HighScoreKmEasy = PlayerPrefs.GetInt("HighScoreKmEasy", HighScoreKmEasy);
        //HighScoreDistEasy = PlayerPrefs.GetInt("HighScoreDistEasy", HighScoreDistEasy);
        //HighScoreKmMedium = PlayerPrefs.GetInt("HighScoreKmMedium", HighScoreKmMedium);
        //HighScoreDistMedium = PlayerPrefs.GetInt("HighScoreDistMedium", HighScoreDistMedium);
        //HighScoreKmHard = PlayerPrefs.GetInt("HighScoreKmHard", HighScoreKmHard);
        //HighScoreDistHard = PlayerPrefs.GetInt("HighScoreDistHard", HighScoreDistHard);
        searchBestLocalScore();
        //BestScore.text = "Best Score:" + km1 + "." + dist1 + "Km";
    }
    public void searchBestScore()
    {
        if (MoveMapAccelerometer.DEasy == true)
        {
            if (km > HighScoreKmEasy)
            {
                PlayerPrefs.SetInt("HighScoreKmEasy", km);
                PlayerPrefs.SetInt("HighScoreDistEasy", (int)dist);
                //dist se memoreaza odata cu acest if
            }
            else
                if (km == HighScoreKmEasy)
                    if (dist >= HighScoreDistEasy)
                        PlayerPrefs.SetInt("HighScoreDistEasy", (int)dist);
            //if (HighScoreDistEasy >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistEasy", 0);
            //    //  PlayerPrefs.SetInt("HighScoreKmEasy", HighScoreKmEasy + 1);
            //}
        }
        if (MoveMapAccelerometer.DMedium == true)
        {

            if (km > HighScoreKmMedium)
            {
                PlayerPrefs.SetInt("HighScoreKmMedium", km);
                PlayerPrefs.SetInt("HighScoreDistMedium", (int)dist);
            }
            else
                if (km == HighScoreKmMedium)
                    if (dist >= HighScoreDistMedium)
                        PlayerPrefs.SetInt("HighScoreDistMedium", (int)dist);
            //if (HighScoreDistMedium >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistMedium", 0);
            //    // PlayerPrefs.SetInt("HighScoreKmMedium", HighScoreKmMedium + 1);
            //}
        }
        if (MoveMapAccelerometer.DHard == true)
        {
            if (km > HighScoreKmHard)
            {
                PlayerPrefs.SetInt("HighScoreKmHard", km);
                PlayerPrefs.SetInt("HighScoreDistHard", (int)dist);
            }
            else
                if (km == HighScoreKmHard)
                    if (dist >= HighScoreDistHard)
                        PlayerPrefs.SetInt("HighScoreDistHard", (int)dist);
            //if (HighScoreDistHard >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistHard", 0);
            //    // PlayerPrefs.SetInt("HighScoreKmHard", HighScoreKmHard + 1);
            //}

        }
    }
    public void searchBestLocalScore()
    {
        if (MoveMapAccelerometer.DEasy == true)
        {
           // km1 = PlayerPrefs.GetInt("HighScoreKmEasy", km1);
          //  dist1 = PlayerPrefs.GetInt("HighScoreDistEasy", (int)dist1);

            HighScoreKmEasy = PlayerPrefs.GetInt("HighScoreKmEasy", HighScoreKmEasy);
            HighScoreDistEasy = PlayerPrefs.GetInt("HighScoreDistEasy", HighScoreDistEasy);
            //if (HighScoreDistEasy >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistEasy", 0);
            //  //  PlayerPrefs.SetInt("HighScoreKmEasy", HighScoreKmEasy + 1);
            //}
            BestScore.text = "Best Score:" + HighScoreKmEasy + "." + HighScoreDistEasy + "Km";

        }
        if (MoveMapAccelerometer.DMedium == true)
        {
          //  km1 = PlayerPrefs.GetInt("HighScoreKmMedium", km1);
          //  dist1 = PlayerPrefs.GetInt("HighScoreDistMedium", (int)dist1);

            HighScoreKmMedium = PlayerPrefs.GetInt("HighScoreKmMedium", HighScoreKmMedium);
            HighScoreDistMedium = PlayerPrefs.GetInt("HighScoreDistMedium", HighScoreDistMedium);
            //if (HighScoreDistMedium >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistMedium", 0);
            //   // PlayerPrefs.SetInt("HighScoreKmMedium", HighScoreKmMedium + 1);
            //}
            BestScore.text = "Best Score:" + HighScoreKmMedium + "." + HighScoreDistMedium + "Km";
        }
        if (MoveMapAccelerometer.DHard == true)
        {
           // km1 = PlayerPrefs.GetInt("HighScoreKmHard", km1);
           // dist1 = PlayerPrefs.GetInt("HighScoreDistHard", (int)dist1);

            HighScoreKmHard = PlayerPrefs.GetInt("HighScoreKmHard", HighScoreKmHard);
            HighScoreDistHard = PlayerPrefs.GetInt("HighScoreDistHard", HighScoreDistHard);
            //if (HighScoreDistHard >= 1000)
            //{
            //    PlayerPrefs.SetInt("HighScoreDistHard", 0);
            //   // PlayerPrefs.SetInt("HighScoreKmHard", HighScoreKmHard + 1);
            //}
            BestScore.text = "Best Score:" + HighScoreKmHard + "." + HighScoreDistHard + "Km";
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Time.deltaTime * 50f * MoveMapAccelerometer.zA * 1.5f);
        distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);

        //if (distance < 400)
        //{
        //    //print("Distance to other: " + (distanceKM + distance));
        //    dista = distance + distanceKM;
        //    distanceText.text = "Distance: " + km + "." + (int)dista + "Km";
        //    dist = (int)dista;
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
        //searchBestScore();
        //searchBestLocalScore();
        //BestScore.text = "Best Score:" + km1 + "." + dist1 + "Km";
        if (zero == 0)
        {
            searchBestScore();
            searchBestLocalScore();
            distance = 0;
         //   distanceKM = 0;
            km = 0;
            dist = 0;
        //    dista = 0;
            //BestScore.text = "Best Score:" + km1 + "." + dist1 + "Km";
            transform.position = new Vector3(0, 2, 12);
            zero = 1;
        }
    }
}
