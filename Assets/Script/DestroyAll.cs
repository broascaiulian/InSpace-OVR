using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour {

   // public GameObject PoPlayer;
    public float z;
    //public GameObject[] Player;
	// Use this for initialization
	void Start () {
      //  Player = GameObject.FindGameObjectsWithTag("Player");

    }
	
	// Update is called once per frame
	void Update ()
    {
        z = GameObject.FindWithTag("Player").transform.position.z;
        if (transform.localPosition.z + 10f < z)
            Destroy(gameObject);
	}
    void OnTriggerEnter(Collider Asteroid)
    {
        if (Asteroid.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
