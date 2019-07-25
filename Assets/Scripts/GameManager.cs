using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static GameManager Insatnce;

	public Text score;

	public Text finalScore;
	public Text HighScore;

	void Awake(){
		Insatnce = this;
	}


	public void StartGame(){
		score.text="0";
		DataManager.Instance.ResetScore ();
		UIManager.Instance.homeView.HideView ();
		UIManager.Instance.gameView.ShowView ();
		UIManager.Instance.pauseView.HideView ();
		UIManager.Instance.gameOverView.HideView ();
		BombManager.Instance.ResetBombs ();	
		BombManager.Instance.RandomBomb ();
	}

	public void EndGame(){
		UIManager.Instance.homeView.HideView ();
		UIManager.Instance.gameView.HideView ();
		UIManager.Instance.pauseView.HideView ();
		UIManager.Instance.gameOverView.ShowView ();
		BombManager.Instance.ResetBombs ();
		GetFinalScore ();
		GetHighScore ();
	}

	public void PauseGame(){
		UIManager.Instance.homeView.HideView ();
		UIManager.Instance.gameView.HideView ();
		UIManager.Instance.pauseView.ShowView ();
		UIManager.Instance.gameOverView.HideView ();

	}
	public void ResumeGame(){
		UIManager.Instance.homeView.HideView ();
		UIManager.Instance.gameView.ShowView ();
		UIManager.Instance.pauseView.HideView ();
		UIManager.Instance.gameOverView.HideView ();
		BombManager.Instance.ResetBombs ();	
		BombManager.Instance.RandomBomb ();

	}

	public void Home(){
		UIManager.Instance.homeView.ShowView ();
		UIManager.Instance.gameView.HideView ();
		UIManager.Instance.pauseView.HideView ();
		UIManager.Instance.gameOverView.HideView ();
	}


	public void GetGameScore(){
		score.text = DataManager.Instance.getCurrentScore ().ToString();
	}

	public void GetFinalScore(){
		finalScore.text = DataManager.Instance.getCurrentScore ().ToString ();
	}

	public void GetHighScore(){
		HighScore.text = DataManager.Instance.GetHighScore ().ToString();	
	}


}
