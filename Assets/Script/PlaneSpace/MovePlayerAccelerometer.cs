using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerAccelerometer : MonoBehaviour {

    public float z;
    public float x;

    void Start ()
    {
       
    }

    void Update()
    {

        if (transform.localPosition.x >= -9.5f && transform.localPosition.x <= 9.5f)
        {
            x = Input.acceleration.x;
            transform.Translate(40f * x * Time.deltaTime, 0, 0);
        }
    }
    void OnTriggerEnter(Collider Other)
    {
        //Debug.Log("a");
        if (Other.gameObject.name == "wallL")
        {
            transform.position = new Vector3(7, 2, 12);
            //Debug.Log("L");
        }
        if (Other.gameObject.name == "wallR")
        {
            transform.position = new Vector3(-7, 2, 12);
           // Debug.Log("R");
        }
    }

}
