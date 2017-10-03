using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_loop : MonoBehaviour {
	
	// public int bottles = 100; 
	// Use this for initialization
	void Start () {

		// while(bottles > 0){
		// 	print(bottles + " bottles of root beer on the wall");
		// 	bottles --;
		// }

		for(int bottles = 100; bottles > 0; bottles --){

			print(bottles + " bottles of root beer on the wall");
		}

		for(int people = 2; people > 0; people --){

			print(people + " One is the lonliest number!");
		}

		for(int gold = 100; gold < 5000; gold ++){

			print(gold + " There's gold in them hills!");
		}

		for(int hearts = 10; hearts > 0; hearts --){

			print(hearts + " GET TO A HOSPITAL! YOU'VE BEEN POISONED!");
		}

		for(int mana = 70; mana > 10; mana --){

			print(mana + " your mana is dropping!");
		}

		for(int energy = 20; energy < 500; energy ++){

			print(energy + " GET WRECKED!");
		}

		for(int lvlUps = 300; lvlUps < 9000; lvlUps ++){

			print(lvlUps + " Level up!");
		}

		for(int heartbreaks = 25; heartbreaks > 0; heartbreaks --){

			print(heartbreaks + " And IIIIIII-EEEEAAAAAIIIII, WILL ALWAYS LOVE YOOOOOUUUU!!!!");
		}

		for(int rocks = 1; rocks < 10; rocks ++){

			print(rocks + " I got a rock....");
		}

		for(int bravery = 100; bravery > 0; bravery --){

			print(bravery + " HELP ME! IT'S COMING FOR ME!!!");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
