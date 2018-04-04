using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRButtonMeniuGame : MonoBehaviour {

    public Text pau;
    GameObject[] Enem;
    GameObject[] Coins;
    GameObject[] Asteroid;
    GameObject Fire;
    //public GameObject wallL;
    //public GameObject wallR;
    public static bool Pause = false;
	// Use this for initialization
	void Start () {
        //Pause = false;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Pause" + Pause);
        //Debug.Log("TimeDelta" + Time.deltaTime);
        //Debug.Log("TimeScale" + Time.timeScale);
    }
    public void Enter()
    {
        Debug.Log("APAAS WEEE");
    }
    public void question()
    {
        if (Pause == false)
            pause();
        else
            resume();
    }
    public void pause()
    {
        pau.text = "Pause";
        Pause = true;
        //wallL.SetActive(false);
        //wallR.SetActive(false);
        //coins
        Coins = GameObject.FindGameObjectsWithTag("coin");
        for (int k = 0; k < Coins.Length; k++)
        {
            Coins[k].GetComponent<coinforce>().enabled = false;
        }
        Enem = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < Enem.Length; i++)
        {
            Enem[i].GetComponent<AsteroidForce>().enabled = false;
            //Debug.Log("APAS "+ i);
        }
        Asteroid = GameObject.FindGameObjectsWithTag("Asteroid");
        for (int i = 0; i < Enem.Length; i++)
        {
            Asteroid[i].GetComponent<AstF>().enabled = false;
            //Debug.Log("APAS " + i);
        }
        //Pause = true;
        //Debug.Log("APAS");
        Time.timeScale = 0;
    }

    public void Pa()
    {
        Pause = true;
    }
    public void restart()
    {
        //GameObject.Find("WaitForSeconds"). = true;
        Pause = false;
        Fire = GameObject.FindGameObjectWithTag("Fire");
        Destroy(Fire);
        //wallL.SetActive(true);
        //wallR.SetActive(true);
        Enem = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < Enem.Length; i++)
        {
            Destroy(Enem[i]);
            //Debug.Log("APAS " + i);
        }
        Coins = GameObject.FindGameObjectsWithTag("coin");
        for (int k = 0; k < Coins.Length; k++)
        {
            Destroy(Coins[k]);
        }
        Asteroid = GameObject.FindGameObjectsWithTag("Asteroid");
        for (int i = 0; i < Enem.Length; i++)
        {
            Destroy(Asteroid[i]);
            //Debug.Log("APAS " + i);
        }
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0f,2f,12f);
        TouchAsteroid.HealthInt = 3;
        DistancePctPlayerAcc.zero = 0;
        DistancePctPlayerController.zero = 0;
        DistancePctPlayerGear.zero = 0;
        MoveMapController.ok = true;
        MoveMapGear.ok = true;
        MoveMapGear.yG = 0.5f;
        MoveMapController.yC = -0.5f;
        //MoveMapController.ok = true;
        Time.timeScale = 1;
        pau.text = "";
    }
    public void resume()
    {
        Time.timeScale = 1;
        //wallL.SetActive(true);
        //wallR.SetActive(true);
        Coins = GameObject.FindGameObjectsWithTag("coin");
        for (int k = 0; k < Coins.Length; k++)
        {
            Coins[k].GetComponent<coinforce>().enabled = true;
        }
        Enem = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < Enem.Length; i++)
        {
            Enem[i].GetComponent<AsteroidForce>().enabled = true;
            //Debug.Log("APAS " + i);
        }
        Asteroid = GameObject.FindGameObjectsWithTag("Asteroid");
        for (int i = 0; i < Enem.Length; i++)
        {
            Asteroid[i].GetComponent<AstF>().enabled = true;
            //Debug.Log("APAS " + i);
        }
        //pau.text = "";
        Pause = false;
      
    }
    public void Menu()
    {
        DistancePctPlayerAcc.zero = 0;
        DistancePctPlayerController.zero = 0;
        DistancePctPlayerGear.zero = 0;
        Time.timeScale = 1;
        Pause = false;
        MoveMapController.ok = true;
        MoveMapGear.ok = true;
        //wallL.SetActive(true);
        //wallR.SetActive(true);
        Application.LoadLevel(0);
    }
    public void Scen()
    {
        DistancePctPlayerAcc.zero = 0;
        DistancePctPlayerController.zero = 0;
        DistancePctPlayerGear.zero = 0;
        Application.LoadLevel(1);
        Time.timeScale = 1;
        Pause = false;
        MoveMapController.ok = true;
        MoveMapGear.ok = true;
        //wallL.SetActive(true);
        //wallR.SetActive(true);
       // Application.LoadLevel(1);
    }
    public void Quit()
    {
        DistancePctPlayerAcc.zero = 0;
        DistancePctPlayerController.zero = 0;
        DistancePctPlayerGear.zero = 0;
        Application.Quit();
        //if() distance
    }

}