using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static GameController GM;
	public int Score { get; set; }

	void Awake() 
	{
		Score = 0;
		if (GM != null)
				GameObject.Destroy (GM);
		else
				GM = this;
		DontDestroyOnLoad (this);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	