﻿using UnityEngine;
using System.Collections;

public class B : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{//Debug.Log("trigghi!");

		GetComponentInParent<Kid>().Metti();
	}
}
