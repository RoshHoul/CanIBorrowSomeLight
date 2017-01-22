using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	// Use this for initialization
	public void Play()
	{
		Application.LoadLevel ("Test");
	}
	public void Exit()
	{
		Application.Quit ();
	}
}
