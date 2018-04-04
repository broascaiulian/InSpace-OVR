using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidForce : MonoBehaviour {

    private float z;
    private bool ok = false;
	// Use this for initialization
	void Start ()
    {
        if (ok == false)
        {
            if (MoveMapAccelerometer.DEasy == true)
            {
                z = -MoveMapAccelerometer.zA;
                ok = true;
            }
            if (MoveMapAccelerometer.DMedium == true)
            {
                z = -MoveMapAccelerometer.zA;
                ok = true;
            }
            if (MoveMapAccelerometer.DHard == true)
            {
                z = -MoveMapAccelerometer.zA;
                ok = true;
            }
            //if (GearVRController.Ast == true)
            //{
            //    z = MoveMapController.CyC;
            //    ok = true;
            //}
            //if (GearVRTouchPad.Ast == true)
            //{
            //    z = -MoveMapGear.CyG;
            //    ok = true;
            //}
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GearVRController.Ast == true && VRButtonMeniuGame.Pause == false)
        {
            z = MoveMapController.CyC;
            // ok = true;
        }
        if (GearVRTouchPad.Ast == true && VRButtonMeniuGame.Pause == false)
        {
            z = -MoveMapGear.CyG;
            // ok = true;
        }
        transform.Translate(0f, 0f, z);
    }
    void Update ()
    {
        //if (-Input.acceleration.z >= 0.3f)
        //{
        //    z = Input.acceleration.z;
        //}
        //transform.position = new Vector3(transform.localPosition.x, 2f, z * 1.25f * Time.deltaTime);

        //transform.position = new Vector3(transform.localPosition.x, 2f, 35f* Time.deltaTime);

        //transform.Translate(0f, 0f, -Time.deltaTime * 50f * MoveMapGear.CyG * 1.5f);
        //if (GearVRController.Ast == true && VRButtonMeniuGame.Pause == false)
        //{
        //    z = MoveMapController.CyC;
        //   // ok = true;
        //}
        //if (GearVRTouchPad.Ast == true && VRButtonMeniuGame.Pause == false)
        //{
        //    z = -MoveMapGear.CyG;
        //   // ok = true;
        //}
        //transform.Translate(0f, 0f,z);
    }
    void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.tag == "Enemy")
             Destroy(gameObject);
    }
}
