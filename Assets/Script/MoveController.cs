using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

   // private float x;
    //private float y;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector2 touchPositonController = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if (transform.localPosition.x >= -9.5f && transform.localPosition.x <= 9.5f)
        {
           // x = 20f * touchPositon.x * Time.deltaTime;
            transform.Translate(20f * touchPositonController.x * Time.deltaTime, 0, 0);
        }
        Vector2 touchPositonGear = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if (transform.localPosition.x >= -9.5f && transform.localPosition.x <= 9.5f)
        {
            // x = 20f * touchPositon.x * Time.deltaTime;
            transform.Translate(20f * touchPositonGear.x * Time.deltaTime, 0, 0);
        }
        //if (transform.localPosition.x >= -9.5f)
        //{
        //    transform.position = new Vector3(-9, 2, 10);
        //}
        //else
        //{
        //    transform.position = new Vector3(9, 2, 10);
        //}
    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "wallL")
        {
            transform.position = new Vector3(9, 2, 9);
            //Debug.Log("map");
        }
        if(Other.gameObject.name == "wallR")
        {
            transform.position = new Vector3(-9, 2, 9);
        }
    }
}