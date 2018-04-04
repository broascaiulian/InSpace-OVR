using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnable : MonoBehaviour {

    public GameObject[] ObjectEnable;
    public GameObject[] ObjectDisable;
    public GameObject[] Destroy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void enable()
    {
        for(int i=0;i<ObjectEnable.Length;i++)
        {
            ObjectEnable[i].SetActive(true);
        }
    }
    public void disable()
    {
        for (int i = 0; i < ObjectDisable.Length; i++)
        {
            ObjectDisable[i].SetActive(false);
        }
    }
    public void Destroyy()
    {
        for (int i = 0; i < Destroy.Length; i++)
        {
           Destroy(Destroy[i]);

        }
    }
}
