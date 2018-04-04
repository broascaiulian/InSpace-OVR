using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodAcc : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
       transform.Translate(0f, 0f, -Time.deltaTime * 50f * MoveMapAccelerometer.zA * 1.5f * Time.timeScale);
    }
}
