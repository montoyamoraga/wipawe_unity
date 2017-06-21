using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class spotifySphere : MonoBehaviour {

	private GameObject s;
	private ArrayList myNodes;

	List<string> points = new List<string> ();

	float PosY = 0;

	// Use this for initialization
	void Start () {

		Debug.Log ("Bitch PLEASE");
		LoadFile ();

		myNodes = new ArrayList ();

		for (int i = 0; i < 119; i++) {
			PosY = float.Parse (points [i]);
			Debug.Log (PosY);

			s = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			s.transform.localScale = new Vector3 (0.01f, 0.01f, 0.01f);
			s.transform.position = new Vector3 (i*0.01f - 0.5f, 0, PosY);

			myNodes.Add (s);
		}


		
	}

	void LoadFile() {
		StreamReader reader = new StreamReader("Assets/valence_value.txt");
		for (int i = 0; i < 119; i++) {
			string text = reader.ReadLine ();
			points.Add (text);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
