using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSleep : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
