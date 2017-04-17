using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class move_cube : MonoBehaviour {

	List<string> points = new List<string> ();

	// Use this for initialization
	void Start () {
		Debug.Log ("Bitch please");
		LoadFile ();
	}

	void LoadFile() {
		StreamReader reader = new StreamReader("Assets/valence_value.txt");
		for (int i = 0; i < 119; i++) {
			string text = reader.ReadLine ();
			points.Add (text);
		}

	}

	void SetTransform(float x, float y) {
		transform.position = new Vector3 (x, y, transform.position.z);
	}


	float frameCount = 0.0f; 
	int step = 0;
	Vector3 currentPos = new Vector3(0,0,0);
	float PosY = 0;


// Update is called once per frame
	void Update () {

		PosY = float.Parse (points [step]);

		currentPos.x = step*0.01f-0.5f;
		currentPos.y += 0.1f * (PosY - currentPos.y);

		this.transform.position = currentPos;

		Debug.Log (currentPos.x);

//		frameCount++;

//		if (frameCount % 10 == 0) {
			if (step < points.Count-1) {
				step++;
//			}
		}





	}
}