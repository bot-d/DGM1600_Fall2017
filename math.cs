using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math : MonoBehaviour {
	public int valueOne; 

	public int valueTwo;

    private int result;

	// Use this for initialization
	void Start () {
	    DoMath(); 
	}
	void DoMath (){
    	result = valueOne + valueTwo; 
	    print(valueOne + " + " + valueTwo + " = " + result);
 	}
	// Update is called once per frame
	// void update () {
        
	//}
}
