using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombManager : MonoBehaviour {
	public static BombManager Instance;

	public List<Bomb> bomb=new List<Bomb>();
	public List<Image> part =new List<Image>();

	void Awake(){
		Instance = this;
	}

	void Deactivate(){
		foreach (Bomb b in bomb) {
			b.gameObject.SetActive (false);
		}
		for (int i = 0; i < part.Count; i++) {
			part [i].gameObject.SetActive (false);
		}
	}

	public void RandomBomb(){
		Deactivate ();
		int randomBomb;
		if (DataManager.Instance.getCurrentScore() < 10) {
			for (int i = 0; i < 3; i++) {
				bomb [i].gameObject.SetActive (true);
			}
			for (int i = 0; i < 3; i++) {
				part [i].gameObject.SetActive (true);
			}
			randomBomb = Random.Range (0, 3);
		} else if (DataManager.Instance.getCurrentScore() < 20) {
			for (int i = 0; i < 6; i++) {
				bomb [i].gameObject.SetActive (true);
			}
			for (int i = 0; i < 6; i++) {
				part [i].gameObject.SetActive (true);
			}
			randomBomb = Random.Range (0, 6);
		} else {
			for (int i = 0; i < bomb.Count; i++) {
				bomb [i].gameObject.SetActive (true);
			}
			for (int i = 0; i < part.Count; i++) {
				part [i].gameObject.SetActive (true);
			}
			randomBomb = Random.Range (0, 9);
		}


		bomb [randomBomb].BombFillM ();
		Debug.Log ("RandomBomb-> "+randomBomb);


	}

	public void ResetBombs(){
		foreach (Bomb b in bomb) {
			b.ResetBomb ();
		}
	}





}
