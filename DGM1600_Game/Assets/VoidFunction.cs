using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFunction : MonoBehaviour {

	public int laserBlast;
	// Use this for initialization
	void Start () {
		DeathStar(laserBlast);
		PodRacer(150);
		PodRacer(200);
		PodRacer(299);
		PodRacer(300);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void DeathStar (int vent){
		print("That's no moon that's a space station!");
		
		print(vent);

		if(vent == 1){
		print("What a n00b!");
		}
		else if(vent == 2){
		print("HA! WHAT A WHAMPRAT!");
		}
		else{
		print("Death star down, i repeat, the Death star is down!");
		}
	}
	void PodRacer (int speed){
		int fast = speed;

	print("Let the podrac.... BEGIN!");

	print(speed);

	if(speed <= 150){
	print("You lose, try again next year Jabba!");
	}

	else if(speed >= 200){ 
	print("It's a tie!");
	}
	else if(speed <= 299){
	print("It's a tie!");
	}
	else{
	print("YOU WIN KID!");
	}

	}

}
