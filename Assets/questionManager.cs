using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionManager : MonoBehaviour {

	public GameObject[] mySearch = new GameObject[3];
	public float timeInterval;

	int currentSearch = 0;

	public void readyToSearch(){
		StartCoroutine(showNextSearch());
	}

	private IEnumerator showNextSearch(){

		yield return new WaitForSeconds(timeInterval);

		if (currentSearch < mySearch.Length) {

			mySearch [currentSearch].SetActive (true);

			currentSearch++;
		
			callSelf();
		
		}

	}

	private void callSelf(){
		
		StartCoroutine(showNextSearch());

	}

}


