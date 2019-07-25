using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseView : BaseView {

	public void OnResume(){
		GameManager.Insatnce.ResumeGame ();
	}

	public void OnHome(){
		GameManager.Insatnce.Home ();
	}
}
