using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DistancePctPlayerGear : MonoBehaviour {

    public static int zero = 1;
    public Text BestScore;
    private float distance;
    private float distanceKM;
    public Text distanceText;
    private float dist;
    private int km;
    public static int HighScoreKmGear;
    public static int HighScoreDistGear;
    private int dist1;
    private int km1;
    // public Transform other;
    // Use this for initialization
    void Start () {
        km = 0;
        searchBestLocalScore();
    }
    public void searchBestScore()
    {
            if (km > HighScoreKmGear)
            {
                PlayerPrefs.SetInt("HighScoreKmGear", km);
                PlayerPrefs.SetInt("HighScoreDistGear", (int)dist);
            }
            else
                if (km == HighScoreKmGear)
                    if (dist >= HighScoreDistGear)
                        PlayerPrefs.SetInt("HighScoreDistGear", (int)dist);
    }
    public void searchBestLocalScore()
    {
            HighScoreKmGear = PlayerPrefs.GetInt("HighScoreKmGear", HighScoreKmGear);
            HighScoreDistGear = PlayerPrefs.GetInt("HighScoreDistGear", HighScoreDistGear);

            BestScore.text = "Best Score:" + HighScoreKmGear + "." + HighScoreDistGear + "Km";
    }
    // Update is called once per frame
    void Update () {
        transform.Translate(0f, 0f, Time.deltaTime * 50f * MoveMapGear.CyG * 1.5f);
        distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);

        //if(distance<400)
        //{
        //    //print("Distance to other: " + (distanceKM + distance));
        //    dist = distance + distanceKM;
        //    distanceText.text = "Distance: " + km +"."+ (int) dist + "Km";
        //    if(distance + distanceKM > 1000)
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
           // distanceKM = 0;
            km = 0;
            dist = 0;
            transform.position = new Vector3(0, 2, 12);
            zero = 1;
        }
    }
}
