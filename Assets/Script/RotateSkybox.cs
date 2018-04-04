using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour {

    public float RS = 1.5f;
	// Use this for initialization
	void Start ()
    {
		
	}
    void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RS);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
