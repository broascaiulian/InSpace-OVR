using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnANDRandom : MonoBehaviour {

    public GameObject[] Object;
    //public Vector3 SpawnValues;
    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;
    public float startWait;
    public bool stop;
    public static float SmW;
    public static float SlW;

    int rand;

   public float x;
    int z;
    int y;

    // Use this for initialization
    void Start () {
        StartCoroutine(waitSpawner());
        SpawnMostWait = SmW;
        SpawnLeastWait = SlW;
        SpawnWait = 3f;
        startWait = Random.Range(0, 5);
        if (GearVRController.Ast == true || GearVRController.Ast == true)
        {
            SpawnMostWait = 3f;
            SpawnLeastWait = 0.5f;
            SpawnWait = 3f;
        }
    }

    // Update is called once per frame'
    void FixedUpdate()
    {
        SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
    }
    void Update ()
    {
        //SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
    }
    public void st()
    {
        StartCoroutine(waitSpawner());
        //amintire cea mai proasta functie
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop && VRButtonMeniuGame.Pause == false)
        {
            rand = Random.Range(0, Object.Length);
            //Vector3 spawnPosition = new Vector3(transform.localPosition.x, 2f, gameObject.transform.position.z);
            Vector3 spawnPosition = new Vector3(Random.Range(-0.75f,0.75f)+transform.localPosition.x, 2f, gameObject.transform.position.z);
            //Instantiate(Object[rand], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            Instantiate(Object[rand], spawnPosition , gameObject.transform.rotation);
            yield return new WaitForSeconds(SpawnWait);
        }
    }
}
