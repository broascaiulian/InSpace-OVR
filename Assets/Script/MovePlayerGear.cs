using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerGear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 touchPositonGear = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if (transform.localPosition.x >= -9.5f && transform.localPosition.x <= 9.5f)
        {
            // x = 20f * touchPositon.x * Time.deltaTime;
            transform.Translate(90f * touchPositonGear.x * Time.deltaTime, 0, 0);
        }
    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "wallL")
        {
            transform.position = new Vector3(7, 2, 12);
            //Debug.Log("map");
        }
        if (Other.gameObject.name == "wallR")
        {
            transform.position = new Vector3(-7, 2, 12);
        }
    }
}
