using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour {

    public GameObject[] Object;
    public Vector3 SpawnValues;
    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;
    public float startWait;
    public bool stop;
    public static float SmW;
    public static float SlW;

    int rand;

    // Use this for initialization
    void Start () {
        StartCoroutine(waitSpawner());
        SpawnMostWait = 0.25f;
        SpawnLeastWait = 0;
        //SpawnWait = 3f;
        startWait = 0;

    }
    void FixedUpdate()
    {
        SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
    }
    // Update is called once per frame
    void Update()
    {
        //SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop && VRButtonMeniuGame.Pause == false)
        {
            rand = Random.Range(0, Object.Length);
            //Vector3 spawnPosition = new Vector3(transform.localPosition.x, 2f, gameObject.transform.position.z);
            Vector3 spawnPosition = new Vector3(Random.Range(-SpawnValues.x, +SpawnValues.x) + transform.localPosition.x, Random.Range(0, +SpawnValues.y), Random.Range(-SpawnValues.z, +SpawnValues.z) + transform.localPosition.z);
            //Instantiate(Object[rand], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            Instantiate(Object[rand], spawnPosition, gameObject.transform.rotation);
            yield return new WaitForSeconds(SpawnWait);
        }
    }
}
