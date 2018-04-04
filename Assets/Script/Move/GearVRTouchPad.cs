using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVRTouchPad : MonoBehaviour {

    public static bool Ast = false;
	// Use this for initialization
	void Start () {
        GearVRController.Ast = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Acces()
    {
        GameObject.FindWithTag("Distance").GetComponent<DistancePctPlayerGear>().enabled = true;
        GameObject.FindWithTag("Map").GetComponent<MoveMapGear>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<MovePlayerGear>().enabled = true;
        Ast = true;
        GameObject.FindWithTag("CameraOVR").GetComponent<CameraFindPlayer>().enabled = true;
    }
}
