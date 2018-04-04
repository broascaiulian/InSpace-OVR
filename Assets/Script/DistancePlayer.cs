using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistancePlayer : MonoBehaviour {

    public float distanceKM;
    //public Text countText;
    public Text distanceText;

    void Start ()
    {
        distanceText.text = "0 Km";
    }

    void Update()
    {
        distanceKM += (int)Time.time / 10f * MoveMapGear.CyG;
        //Debug.Log("time" + distanceKM);
        distanceText.text = distanceKM + "Km";
        //Debug.Log("real" + Time.realtimeSinceStartup);

    }

}