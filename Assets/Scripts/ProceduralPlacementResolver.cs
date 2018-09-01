﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralPlacementResolver : MonoBehaviour {
	
	[SerializeField]
	private LayerMask layer;

	[SerializeField]
	private float maxDistanceRay;

	[SerializeField]
	private float maxAngle;

	[SerializeField]
	private float distanceFromCollisionPosition = 0f;

	private Vector3 point;

	private void Start() {
		RaycastHit hit;
		if(Physics.Raycast(transform.position + Vector3.up * 50f, -Vector3.up, 
		out hit, maxDistanceRay, layer))
		{
			point = hit.point;
			transform.position = hit.point + Vector3.up * distanceFromCollisionPosition;	
			float angle = Vector3.AngleBetween(Vector3.up, hit.normal) * Mathf.Rad2Deg;			
			if(angle > maxAngle) {
				transform.rotation = Quaternion.AngleAxis(maxAngle, Vector3.up);	
			}
			else {					
				transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);		
			}				
		}
		Destroy(this);
	}

}
