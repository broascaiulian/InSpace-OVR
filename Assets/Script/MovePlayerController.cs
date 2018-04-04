using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerController : MonoBehaviour {

    //public OVRInput.Controller controller;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote))
        {
            ControllerLeft();
        }
        if (OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote))
        {
            ControllerRight();
        }

    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "wallL")
        {
            transform.position = new Vector3(7, 2, 12);
            //Debug.Log("map");
        }
        if (Other.gameObject.name == "wallR")
        {
            transform.position = new Vector3(-7, 2, 12);
        }
    }
    void ControllerLeft()
    {
        Vector2 touchPositonController = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad,OVRInput.Controller.LTrackedRemote);
        if (transform.localPosition.x >= -9.5f && transform.localPosition.x <= 9.5f)
        {
            // x = 20f * touchPositon.x * Time.deltaTime;
            transform.Translate(20f * touchPositonController.x * Time.deltaTime, 0, 0);
        }
    }
    void ControllerRight()
    {
        Vector2 touchPositonController = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);
        if (transform.localPosition.x >= -9.5f && transform.localPosition.x <= 9.5f)
        {
            // x = 20f * touchPositon.x * Time.deltaTime;
            transform.Translate(20f * touchPositonController.x * Time.deltaTime, 0, 0);
        }
    }
}
