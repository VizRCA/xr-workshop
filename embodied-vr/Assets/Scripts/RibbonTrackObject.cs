using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kvant;

public class RibbonTrackObject : MonoBehaviour {

	Ribbon r;
	[SerializeField]
	Transform trackedObject;
	// Use this for initialization
	void Start () {
		r = GetComponent<Ribbon> ();
	}
	
	// Update is called once per frame
	void Update () {
		r.attractor = trackedObject.position;
	}
}
