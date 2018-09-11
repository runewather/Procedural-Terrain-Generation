﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelData : ScriptableObject {
	public float seed = 1f;
	public int width;
	public int height;
	public int depth;
	public float exp;
	public List<Octave> octaves;
	public List<ProceduralPlacementData> objPlacementData;
	[HideInInspector]
	public List<GameObject> collectables = new List<GameObject>();
	public List<PortalData> portals = new List<PortalData>();
	public Vector3 playerStartPosition;
}
