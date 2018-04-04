using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVRController : MonoBehaviour {

    public static bool Ast= false;
	// Use this for initialization
	void Start () {
        GearVRTouchPad.Ast = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Acces()
    {
        GameObject.FindWithTag("Distance").GetComponent<DistancePctPlayerController>().enabled = true;
        GameObject.FindWithTag("Map").GetComponent<MoveMapController>().enabled = true;
        GameObject.FindWithTag("Player").GetComponent<MovePlayerController>().enabled = true;
        Ast = true;
        GameObject.FindWithTag("CameraOVR").GetComponent<CameraFindPlayer>().enabled = true;
    }
}
