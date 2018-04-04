using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodGearVR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0f, 0f, -Time.deltaTime * 50f * MoveMapGear.CyG * 1.5f);
    }
}
