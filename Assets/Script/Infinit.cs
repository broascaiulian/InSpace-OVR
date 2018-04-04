using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinit : MonoBehaviour {

    public Transform roadPrefab;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Other)
    {
        //ForMap
        //Instantiate(roadPrefab, new Vector3(-15, 0, transform.parent.position.z + 400), roadPrefab.rotation);
        //ForPlane
        if (Other.gameObject.tag == "Player")
        {
            Instantiate(roadPrefab, new Vector3(0, 0, transform.parent.position.z + 1000.00105f), roadPrefab.rotation);
            //Debug.Log("map");
        }
    }
}
