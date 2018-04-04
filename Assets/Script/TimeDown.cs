using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeDown : MonoBehaviour {

    public Text text;
    private int Contor = 3;
	// Use this for initialization
	void Start () {
        //Contor = 3;
        //text.text = ""+Contor;
        StartCoroutine(StartC());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Staaart()
    {
        StopCoroutine(StartC());
        StartCoroutine(StartC());
    }
    IEnumerator StartC()
    {
        //print(Time.time);
        yield return new WaitForSeconds(2);
        text.text = "3";
        yield return new WaitForSeconds(1);
        text.text = "2";
        yield return new WaitForSeconds(1);
        text.text = "1";
        yield return new WaitForSeconds(1);
        text.text = "Let's go!";
        yield return new WaitForSeconds(1);
        text.text = "";
        //GameObject.Find("WaitForSeconds").active = false;
        //print(Time.time);
    }
}
