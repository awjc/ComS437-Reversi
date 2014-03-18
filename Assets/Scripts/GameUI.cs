using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour {
	
	private Texture2D _play;
	
	// Use this for initialization
	void Start () {
		_play = Resources.Load ("menu-button-md") as Texture2D;
		
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (0, 30, 100, 20), _play)) 
		{
			Application.LoadLevel("menu");
		}
		
		GUILayout.Label ("Score: " + GameController.GM.Score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
