using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour {

    public GameObject[] Object;
    public Vector3 SpawnValues;
    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;
    public int startWait;
    public bool stop;

    int rand;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitSpawner());	
	}
	
	// Update is called once per frame
	void Update () {
        SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
	}
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while(!stop)
        {
            rand = Random.Range(0, Object.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), 0.5f, Random.Range(-SpawnValues.z, SpawnValues.z));
            //Instantiate(Object[rand], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            Instantiate(Object[rand], spawnPosition + transform.position, gameObject.transform.rotation);
            yield return new WaitForSeconds(SpawnWait);
        }
    }
}
