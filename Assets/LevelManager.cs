using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("Level load for: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitGame() {
		Debug.Log("Trying to quit!");
		Application.Quit();
	}
}
