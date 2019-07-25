using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
	public static DataManager Instance;

	private string HighScore="HighScore";
	private int currentScore;

	void Awake(){
		Instance = this;
	}

	public void SetHighScore(int playerScore){
		if (!PlayerPrefs.HasKey (HighScore)) {
			PlayerPrefs.SetInt (HighScore, 0);
		} else {
			if (PlayerPrefs.GetInt (HighScore) < playerScore)
				PlayerPrefs.SetInt (HighScore,playerScore);
		}
	}

	public int GetHighScore(){
		return PlayerPrefs.GetInt (HighScore);
	}

	public int getCurrentScore(){
		return currentScore;
	}

	public void SetCurrentScore(int score){
		if (score > 0) {
			currentScore = score;
		}
	}

	public void SetScore(int score){
		currentScore += score;
	}

	public void ResetScore(){
		currentScore = 0;
	}

}
	