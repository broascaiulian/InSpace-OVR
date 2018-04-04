using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanteControl : MonoBehaviour {

   // private Rigidbody rigid;
    public float xf;
    public float rf;
    void Start()
    {
       // rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rf = GameObject.FindWithTag("Player").transform.rotation.z;
        xf = Input.acceleration.x;
        if (rf < 0.025 && rf > -0.025)
        { 
            transform.Rotate(0.0f, 0.0f, -xf * 10f);
        }
    }
}
