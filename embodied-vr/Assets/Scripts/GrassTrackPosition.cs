using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kvant;

public class GrassTrackPosition : MonoBehaviour {
	public Transform trackedPosition;
	Grass g;
	// Use this for initialization
	void Start () {
		g = GetComponent<Grass> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (trackedPosition)
			g.offset = new Vector2 (trackedPosition.position.x,
				trackedPosition.position.z);
	}
}
