using UnityEngine;
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
		Debug.Log("Click!");
		GameController.GM.Score += 100;
		Debug.Log(GameController.GM.Score);
	}
}
