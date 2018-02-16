using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityCounter : MonoBehaviour {

	Vector3 pPos;

	public float diff = 0;
	public float max = 0;
	public float min = 0;

	// Use this for initialization
	void Start () {
		pPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		diff = Vector3.Distance (transform.position, pPos);
		if (diff > max)
			max = diff;
		else if (diff < min)
			min = diff;
		pPos = transform.position;
	}
}
