using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logical : MonoBehaviour {

public string luke = "Jedi";


public string vader = "sith";

public bool leia = true;

public string darkSide = "Darth Maul";

public string lightSide = "Obi Wan";

public int num1 = 10;

public float num2 = 10.5f; 

	// Use this for initialization
	void Start () {
		// if(luke=="Jedi" && vader=="Sith"){
		// 	print("Vader is yo annie!");
		// }
		// else if (luke=="Jawa" && vader=="Sith"){
		// 	print("Utini!");
		// }
		// else if(luke=="Jedi" && vader=="Sith"){
		// 	print("Nooooooooooo! Thats not true..... That's impossible!");
		// }
		// else{
		// 	print("The End!");
		// }
		// if(leia){
		// 	print("no, there is another.");
		// }
		// else if(!leia){
		// 	print("Hurray! Now i can date luke!");
		// }
		// else
		// 	print("Han shot first!");
		if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
			print("Meeza Evil Bad Bad Sith Lord");
		}
		else if(lightSide == "Boba Fett" || darkSide =="Darth Maul"){
			print("As you wish, my master");
		}
		else{
			print("Not the younglings!");
		}
		if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if(num1 == 10 || num2 == 10){
			print("NOOOOOOOOOO!");
		}
		else{
			print("BLAAAARGH!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
