using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heros = new string[6];

	// Use this for initialization
	void Start () {
		heros[0] = "Batman";
		heros[1] = "Superman";
		heros[2] = "Wolverine";
		heros[3] = "Spiderman";
		heros[4] = "Jean Gray";
		heros[5] = "Martian Man-Hunter";

		print(heros[3]);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
