using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour {
	public Image selfImage;
	float rate =10.0f;
	public IEnumerator fillRoutine;


	public void BombFillM(){
		fillRoutine = BombFill();
		StartCoroutine (fillRoutine);
		Debug.Log ("Coroutine Calling");

	}


	 IEnumerator BombFill(){
		Debug.Log ("Bomb selected -> " + selfImage.name);
		while (selfImage.fillAmount != 1.0f) {
			selfImage.fillAmount +=  1.0f/rate * Time.deltaTime;
			if (selfImage.fillAmount == 1) {
//				Debug.Log ("You Loose");
				int current = DataManager.Instance.getCurrentScore();
				DataManager.Instance.SetHighScore (current);
				GameManager.Insatnce.EndGame();

			}

			yield return null;

		}

	}

	public void ResetBomb(){
		selfImage.fillAmount = 0f;

	}




	public void CheckFillAmount(){
		if(fillRoutine!=null)
		StopCoroutine (fillRoutine);
		if(selfImage.fillAmount!=1 && selfImage.fillAmount!=0 ){
			if (selfImage.fillAmount < 0.5) {
				DataManager.Instance.SetScore (2);
			} else {
				DataManager.Instance.SetScore (1);
			}
			GameManager.Insatnce.GetGameScore ();
			Debug.Log ("You WIN");
			ResetBomb ();
			BombManager.Instance.RandomBomb ();


		}


		if (selfImage.fillAmount == 1) {
//			Debug.Log (selfImage.name);
//			Debug.Log ("HI->" + selfImage.fillAmount);
		}

	}
	

}
