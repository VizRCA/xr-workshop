using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kvant;

public class WallPositionMapper : MonoBehaviour {

	public Transform trackedPosition;
	float normalised = 0;
	Wall w;
	// Use this for initialization
	void Start () {
		w = GetComponent<Wall> ();
		if (trackedPosition)
			normalised = PositionDifference();
	}

	// Update is called once per frame
	void Update () {
		if (trackedPosition && w)
			w.positionNoiseAmplitude = Mathf.Clamp01(
				1-(PositionDifference()/normalised));
	}

	float PositionDifference(){
		return Vector3.Distance (trackedPosition.position, transform.position);
	}
}
