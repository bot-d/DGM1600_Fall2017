using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {
	public string townCenter = "main";


	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main":
				print("Welcome to Main Street!"); 
			break; 
			case "blacksmith":
				print("The blacksmith grumbles as you pick through the sword bin");
			break;
			case "bakery":
				print("Mmmmmmmm baked goodness!");
			break;
			case "Morgue":
				print("peeeeeeeeeeeeeeeeyew! Dead things yuck!");
			break;
			default:
				print("I don't know what you're talking about!");
			break;

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
