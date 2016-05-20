using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int min = 1;
	int max = 1000;
	int guess = 500;
	int maxGuesses = 5;
	int currentNumGuesses;
	
	public Text guessNumberText;
	public Text guessRemainingText;

	void Start () {
		max = max + 1;
		currentNumGuesses = 0;
		guessRemainingText.text = "Number of guesses left: " + maxGuesses;
	}
	
	public void Correct(){
		Application.LoadLevel("Lose");
	}
	
	public void GuessHigher () {
		min = guess;
		NextGuess();
	}
	
	public void GuessLower () {
		max = guess;
		NextGuess();
	}
	
	void NextGuess() {
		guess = (max + min) / 2;
		currentNumGuesses++;
		if (maxGuesses <= currentNumGuesses) {
			Application.LoadLevel("Win");
		}
		guessNumberText.text = "" + guess;
		guessRemainingText.text = "Number of guesses left: " + (maxGuesses - currentNumGuesses);
	}
}
