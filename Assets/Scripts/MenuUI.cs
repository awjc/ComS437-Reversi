using UnityEngine;
using System.Collections;

public class MenuUI : MonoBehaviour {

	private Texture2D _play;

	// Use this for initialization
	void Start () {
		_play = Resources.Load ("menu-button-md") as Texture2D;

	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width / 3, Screen.height / 3, Screen.width / 3, Screen.height / 3), _play)) 
		{
			Application.LoadLevel("game");
		}

		GUILayout.Label ("Score: " + GameController.GM.Score);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
