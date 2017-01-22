using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour {
	public float counter;
	// Use this for initialization
	void Start () {
		counter = 0f;
	}

	// Update is called once per frame
	void Update () 
	{
		counter = counter + 0.1f;
		if (counter > 24f) 
		{
			Application.LoadLevel ("Menu");
		}
	}
}
