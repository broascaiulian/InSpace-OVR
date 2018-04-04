using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMapGear : MonoBehaviour
{

    public static float yG;
    public static float CyG;
    public static bool ok = true;
    // Use this for initialization
    void Start()
    {
        if (ok)
        {
            yG = 0.5f;
            ok = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Vector2 touchPositonGear = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        //if (touchPositonGear.y > 0.3f)
        //{
        //    yG = -Time.deltaTime * 100f * touchPositonGear.y * 1.5f;
        //    transform.Translate(0f, 0f, yG);
        //}
        //transform.Translate(0f, 0f, yG);
        if(OVRInput.Get(OVRInput.Button.DpadUp) && yG < 1f)
        {
            yG = yG + 0.1f;
            transform.Translate(0f, 0f, -Time.deltaTime * 50f * yG * 1.5f);
        }
        if(OVRInput.Get(OVRInput.Button.DpadDown) && yG > 0.3f)
        {
            yG = yG - 0.1f;
            transform.Translate(0f, 0f, -Time.deltaTime * 50f * yG * 1.5f);
        }
        if (VRButtonMeniuGame.Pause == false)
            CyG = yG;
        else
            yG = 0;
        transform.Translate(0f, 0f, -Time.deltaTime * 50f * yG * 1.5f);
    }
}
