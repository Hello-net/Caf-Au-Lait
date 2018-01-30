using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sosuu : MonoBehaviour {

	int i,j;

	// Use this for initialization
	void Start () {
		Debug.Log("デバッグログ");
		Sosu ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Sosu(){
		for (i = 2; i <= 101; i++) {
		
			for (j = 2; j < i; j++) {
			
				if (i % j == 0) {
					break;
				}
			}
			//素数か？
			if (i == j) {
				Debug.Log (i);
			}
		}
	
	
	
	}
}
