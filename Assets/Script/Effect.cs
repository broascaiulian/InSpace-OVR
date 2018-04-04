using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

    private float Ts;
    // Use this for initialization
	void Start () {
        StartCoroutine(StartC());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator StartC()
    {
        //print(Time.time);
        yield return new WaitForSeconds(0.15f);
        Destroy(gameObject);
        //GameObject.Find("WaitForSeconds").active = false;
        //print(Time.time);
    }
}
