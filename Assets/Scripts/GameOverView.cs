﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverView : BaseView {
	public Text score;
	public Text highScore;

	public void  OnPlayGameOver(){
		GameManager.Insatnce.Home ();
	}
}
