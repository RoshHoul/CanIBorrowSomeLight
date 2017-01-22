using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour {
	public Animator Snap;
	public Animator PlayerAnims;
	public GameObject EndScreen;
    public static int deathCount = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.gameObject.tag == "Player") {
			Snap.SetInteger ("States", 1);
			col.GetComponent<PlayerMovement> ().enabled = false;
			PlayerAnims.SetInteger ("States", 5);
			EndScreen.SetActive (true);
			col.GetComponentInChildren<Coin> ().enabled = false;
			col.GetComponentInChildren<CoinLeft>().enabled = false;
		} 
		else 
		{
			Snap.SetInteger ("States", 0);
		}
	}
}
