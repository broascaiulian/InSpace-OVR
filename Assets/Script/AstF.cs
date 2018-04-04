using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstF : MonoBehaviour {

    public float z;
    //public float x;
    //public Rigidbody rigid;
	// Use this for initialization
	void Start () {
        if (MoveMapAccelerometer.DEasy == true)
        {
            z = -MoveMapAccelerometer.zA;
        }
        if (MoveMapAccelerometer.DMedium == true)
        {
            z = -MoveMapAccelerometer.zA;
        }
        if (MoveMapAccelerometer.DHard == true)
        {
            z = -MoveMapAccelerometer.zA;
        }
        if (GearVRController.Ast == true)
        {
            z = MoveMapController.CyC;
            // ok = true;
        }
        if (GearVRTouchPad.Ast == true)
        {
            z = -MoveMapGear.CyG;
            // ok = true;
        }

    }
    void FixedUpdate()
    {
        transform.Translate(0f, 0f, Random.Range(z,2.5f*z));
        //rigid.AddForce(0, 0, x * Time.unscaledDeltaTime);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
