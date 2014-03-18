using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	private static GameController _gm;
	public static GameController GM
	{
		get
		{
			return _gm;
		}
	}
	public int Score { get; set; }

	void Awake() 
	{
		Score = 0;
		if (_gm == null)
			_gm = this;
		DontDestroyOnLoad (this);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	