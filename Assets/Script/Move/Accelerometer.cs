using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Acces()
    {
        GameObject.FindWithTag("Distance").GetComponent<DistancePctPlayerAcc>().enabled = true;
        GameObject.FindWithTag("Map").GetComponent<MoveMapAccelerometer>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<MovePlayerAccelerometer>().enabled = true;
        GameObject.FindWithTag("CameraOVR").GetComponent<CameraFindPlayer>().enabled = true;
    }
}
