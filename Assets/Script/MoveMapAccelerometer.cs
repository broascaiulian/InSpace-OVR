using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class MoveMapAccelerometer : MonoBehaviour
{
    public static float zA;
    public static bool DEasy = false;
    public static bool DMedium = false;
    public static bool DHard = false;
    //public static float CzA;
    //public bool ok = true;

    //public float xatstart = 0;
    //public float yatstart = 0;
    //public float zatstart = 0;
    //public Vector3 dir;
    //public float z;
    //public float x;
    //public float y;
    //// Use this for initialization
    void Start()
    {
        //xatstart = Input.acceleration.x;
        //yatstart = Input.acceleration.y;
        //zatstart = Input.acceleration.z;
    }

    void Update()
    {
        if(VRButtonMeniuGame.Pause == false)
            transform.Translate(0f, 0f, -zA);
        else
            transform.Translate(0f, 0f, 0);
    }
    public void easy()
    {
        //zA= Time.deltaTime * 50f * 0.3f * 1.5f;
        zA = Time.deltaTime * 50f * 0.5f * 2f;
        SpawnANDRandom.SmW = 3f;
        SpawnANDRandom.SlW = 0.5f;
        DEasy = true;
        DMedium = false;
        DHard = false;
    }
    public void medium()
    {
        //zA = Time.deltaTime * 50f * 0.6f * 1.5f;
        zA = Time.deltaTime * 50f * 0.75f * 2f;
        SpawnANDRandom.SmW = 2.5f;
        SpawnANDRandom.SlW = 0.5f;
        DMedium = true;
        DEasy = false;
        DHard = false;
    }
    public void hard()
    {
        //zA = Time.deltaTime * 50f * 1f * 1.5f;
        SpawnANDRandom.SmW = 2f;
        SpawnANDRandom.SlW = 0.5f;
        zA = Time.deltaTime * 50f * 1f * 2f;
        DHard = true;
        DEasy = false;
        DMedium = false;
    }
}
    //// Update is called once per frame
    //void Update()
    //{
    //    dir.y = (-Input.acceleration.y - yatstart);
    //    dir.z = (Input.acceleration.z - zatstart);
    //    dir.x = (Input.acceleration.x - xatstart);

    //    z = Input.acceleration.z;
    //    y = Input.acceleration.y;
    //    x = Input.acceleration.x;
    //}

