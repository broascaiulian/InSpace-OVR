﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFindPlayer : MonoBehaviour {

    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;
    private GameObject Player;


    private float transition = 0.0f;
    private float animationDuration = 2.0f;
    private Vector3 animationOffset = new Vector3(0, 10, 10);
    // Use this for initialization
    void Start() {
        Player = GameObject.FindWithTag("Player");
        lookAt = Player.transform;
        startOffset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = lookAt.position + startOffset;
        //x
        moveVector.x = 0;
        //y
        moveVector.y = Mathf.Clamp(moveVector.y, 0, 10);

        if(transition > 1.0f)
        {
            transform.position = moveVector;
        }
        else
        {
            transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
            transition += Time.deltaTime * 1 / animationDuration;
        }
		
	}
}
