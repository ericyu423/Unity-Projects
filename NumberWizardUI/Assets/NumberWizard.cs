using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 10;
	// Use this for initialization

	public Text text; //type Text name text  in swift public var text: Text!
	void Start () {
		
		StartGame ();

	}

	void StartGame ()
	{
		max = 1000;
		min = 1;
		nextGuess();





	}


	public void GuessHigher ()
	{
		min = guess;
		nextGuess();

	}

	public void GuessLower ()
	{
		max = guess;
		nextGuess();
	}



	public void nextGuess ()
	{
		guess = Random.Range(min,max+1);
		//guess = (min + max) / 2;
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {

			SceneManager.LoadScene("Win");
		}

	}




}
