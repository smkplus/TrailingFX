using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.forward*Time.deltaTime*speed);
	}
}
