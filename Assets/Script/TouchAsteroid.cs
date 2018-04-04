using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchAsteroid : MonoBehaviour {

    private int Coinssss;
    public Text Coinss;
    public AudioClip Coin;

    public GameObject Fire;
    //public AudioSource SourceCoin;

    GameObject[] Enem;
    GameObject[] Coins;
    public GameObject Menu;
    public GameObject Pause;
    public Text HealthText;
    public Text DeadText;
    public static int HealthInt;
    private int km;
    private int dist;

    public AudioSource Source;
    public AudioClip Expl;


    //public AudioSource SourceBurn;
    public AudioClip Burn;
    //public Material MyRend;

    // Use this for initialization
    void Start () {
        HealthInt = 3;
        HealthText.text = "Health: " + HealthInt;

        Coinssss = PlayerPrefs.GetInt("Coins", Coinssss);
        Coinss.text = "Coins: " + Coinssss;
    }
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerEnter(Collider Asteroid)
    {
        if (Asteroid.tag == "Enemy")
        {
            //Destroy(gameObject);
            Debug.Log("ATIIINS" + gameObject);
            if (HealthInt > 1)
            {
                HealthInt--;
                Source.PlayOneShot(Expl);
                Instantiate(Fire, gameObject.transform.position, gameObject.transform.rotation);
                HealthText.text = "Health: " + HealthInt;
                //MyRend.SetFloat("_Mode", 3);
            }
            else
            {
                Instantiate(Fire, gameObject.transform.position, gameObject.transform.rotation);
                Source.PlayOneShot(Expl);
                Source.PlayOneShot(Burn);
                //SourceBurn.PlayOneShot(Burn);
                HealthText.text = "";
                DeadText.text = "Dead";
                VRButtonMeniuGame.Pause = true;
                Menu.SetActive(true);
                Pause.SetActive(false);
                STOP();
                //Time.timeScale = 0;
            }
        }
        else
        {
            if(Asteroid.tag == "coin")
            {
                PlayerPrefs.SetInt("Coins", Coinssss + 1);
                Source.PlayOneShot(Coin);
                Coinssss = PlayerPrefs.GetInt("Coins", Coinssss);
                Coinss.text = "Coins: " + Coinssss;
            }
        }
    }
    public void WRITE()
    {
        HealthInt = 3;
        HealthText.text = "Health: " + HealthInt;
        Source.Stop();
        //SourceBurn.Stop();
    }
    public void STOP()
    {
        Coins = GameObject.FindGameObjectsWithTag("coin");
        for (int k = 0; k < Coins.Length; k++)
        {
            Coins[k].GetComponent<coinforce>().enabled = false;
        }
        Enem = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < Enem.Length; i++)
        {
            Enem[i].GetComponent<AsteroidForce>().enabled = false;
        }
        Time.timeScale = 0;
      // GameObject.FindGameObjectWithTag("wallL").SetActive(false);
       //GameObject.FindGameObjectWithTag("wallR").SetActive(false);
    }
}
