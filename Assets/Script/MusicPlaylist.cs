using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaylist : MonoBehaviour {

    public AudioClip[] Melodii;
    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
        //audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
	}
	private AudioClip RandomMelodii()
    {
        return Melodii[Random.Range(0, Melodii.Length)];
    }
	// Update is called once per frame
	void Update () {
		if(!audioSource.isPlaying)
        {
            audioSource.clip = RandomMelodii();
            audioSource.Play();
        }
	}
}
