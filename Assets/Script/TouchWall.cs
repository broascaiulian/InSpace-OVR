using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWall : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "wall")
        {

        }
    }

}
