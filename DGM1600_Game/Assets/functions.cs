using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing AAAAALL THE THINGS!");
	}

	void start(){
		DoStuff();
		int result = AddNumbers(6,2);
			print(result);
	}

	public int AddNumbers(int num1,int num2){

		int result = num1 + num2;

		 return result;
	}


}
