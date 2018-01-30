using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject Cube;
	public Transform SpawnPoint;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (Cube,SpawnPoint);
		}
	}
}
