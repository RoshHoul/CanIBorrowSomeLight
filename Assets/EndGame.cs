﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
	public GameObject WinScreen;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other)
    {
		if (other.gameObject.tag == "Player") 
		{
			Debug.Log("EBALO SI E MAIKATA");
			WinScreen.SetActive (true);
			Time.timeScale = 0f;
		}
           
			
    }
}
