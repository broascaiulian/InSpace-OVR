using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class MoveMapController : MonoBehaviour {

    public static float yC;
    public static float CyC;
    public static bool ok = true;
    //public OVRInput.Controller controller;
	// Use this for initialization
	void Start () {
        //de identificat daca e L sau R
        if (ok)
        {
            yC = -0.5f;
            ok = false;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote) || OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote))
        //{
        //    Vector2 touchPositonController = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        //    if (touchPositonController.y > 0.3f)
        //    {
        //        yC = -Time.deltaTime * 50f * touchPositonController.y * 1.5f;
        //        transform.Translate(0f, 0f, yC);
        //    }
        //    transform.Translate(0f, 0f, yC);
        //}
        if (VRButtonMeniuGame.Pause == false)
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote))
            {
                ControllerLeft();
            }
            if (OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote))
            {
                ControllerRight();
            }
            //doar pt PC proba
            transform.Translate(0f, 0f, yC);
        }
        else
        {
            transform.Translate(0f, 0f, 0f);
        }
       
        CyC = yC;
    }
    void ControllerLeft()
    {
        Vector2 touchPositonController = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.LTrackedRemote);
        if (touchPositonController.y > 0.3f)
        {
            yC = -Time.deltaTime * 50f * touchPositonController.y * 1.5f;
            transform.Translate(0f, 0f, yC);
        }
        transform.Translate(0f, 0f, yC);

    }
    void ControllerRight()
    {
        Vector2 touchPositonController = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);
        if (touchPositonController.y > 0.3f)
        {
            yC = -Time.deltaTime * 50f * touchPositonController.y * 1.5f;
            transform.Translate(0f, 0f, yC);
        }
        transform.Translate(0f, 0f, yC);
    }

}
