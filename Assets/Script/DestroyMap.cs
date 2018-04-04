using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMap : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    void OnTriggerEnter(Collider Other)
    {

        if (Other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //    Debug.Log("delete");
        }

    }

}
