﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : BaseView {
	

	public void OnPause(){
		GameManager.Insatnce.PauseGame ();
	}



}
