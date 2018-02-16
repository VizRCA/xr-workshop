using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kvant;
using Klak.Math;

public class SwarmVelocityMapper : MonoBehaviour {
	[SerializeField]
	GameObject source;

	Swarm target;

	VelocityCounter vc;

	public float velMapper = 0;
	public float mapLow = 0.5f;
	public float mapHigh = 20;

	// Use this for initialization
	void EnableMapper () {
		if (source)
			vc = source.GetComponent<VelocityCounter> ();
			target = GetComponent<Swarm> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (vc && target) {
			velMapper = BasicMath.Map (vc.diff, vc.min, vc.max, mapLow, mapHigh);
			target.forcePerDistance = velMapper;
		} else {
			EnableMapper ();
		}
	}
}
