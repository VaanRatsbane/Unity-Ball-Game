using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public float distance;
	public float angle;
	public Transform playerTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distanceVector = new Vector3 (0, 0, -distance);
		this.transform.position = playerTransform.position + (Quaternion.Euler(angle, 0, 0) * distanceVector);
	}
}
