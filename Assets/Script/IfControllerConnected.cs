using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IfControllerConnected : MonoBehaviour {

    public GameObject WithController;
    public GameObject WithNotController;
    public GameObject Text;
    public Text Controller;
    private bool ok = false;
	// Use this for initialization
    public void print()
    {
        if(ok)
            Controller.text = "Your Controller is not connected.";
    }
    public void printSpace()
    {
            Controller.text = "";
    }
    void Start () {
        ok = false;
        if (OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote) || OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote))
        {
            WithNotController.SetActive(false);
            Destroy(Text);
            //Destroy(WithNotController);
            //text.text = "controller is connected";
        }
        else
        {
            WithController.SetActive(false);
            ok = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
