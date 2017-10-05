using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log("love load requested for: " + name);
		SceneManager.LoadScene(name);
	}

	public void QuitGame ()
	{

		//Application.Quit; 
	
	}






}
