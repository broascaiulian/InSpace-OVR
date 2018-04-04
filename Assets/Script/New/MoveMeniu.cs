using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMeniu : MonoBehaviour {

    Vector3 Endpos;
    Vector3 StartPos;

    private bool okf = false;
    private bool okd = false;
    public Transform TargetStart;
    public Transform TargetEnd;
    public float speed = 10;
	// Use this for initialization
	void Start () {
        StartPos = transform.position;
        Endpos = transform.position + Vector3.up * speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (okf)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetEnd.position, speed * Time.unscaledDeltaTime);
        }
        if (okd)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetStart.position, speed * Time.unscaledDeltaTime);
        }
    }
    public void Forward()
    {
        okf = true;
        okd = false;
        //transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
        //if (ok)
        //{
        //    transform.position = Vector3.Lerp(StartPos, Endpos, way);
        //    ok = false;
        //}
    }
    public void downward()
    {
        okd = true;
        okf = false;
        //if (ok == false)
        //{
        //    transform.position = Vector3.Lerp(Endpos, StartPos, -way);
        //    ok = true;
        //}
    }
}
