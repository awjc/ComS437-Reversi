﻿using UnityEngine;
using System.Collections;

public class ObjectClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		GameController.GM.Score += 100;
	}
}
