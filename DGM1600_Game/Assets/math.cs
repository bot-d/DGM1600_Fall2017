using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math : MonoBehaviour {

public int valueOne;

public int valueTwo;
private int result;

public int valueThree;

public int valueFour; 

public int valueFive;

public int valueSix;

public int valueSeven;
public int valueEight;
	// Use this for initialization
	void Start () {
		DoMath();
	}
	
	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + "=" + result);

		result = valueThree - valueFour;
		
		print(valueThree + " - " + valueFour + "=" + result);

		result = valueFive * valueSix; 	 

		print(valueFive + " x " + valueSix + "=" + result);

		result = valueSeven / valueEight;

		print(valueSeven + " / " + valueEight + "=" + result);

	}
	// // Update is called once per frame
	//void Update () {
		
	//}
}
