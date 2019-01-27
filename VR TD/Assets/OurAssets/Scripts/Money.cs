using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

	public int cash = 0;
	public int startingCash = 500;

	// Use this for initialization
	void Start () {
		cash = startingCash;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int getCash () {
		return cash;
	}

	public void addCash (int amount) {
		cash += amount;
	}

	public void removeCash (int amount) {
		cash -= amount;
	}
}
