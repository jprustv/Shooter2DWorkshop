﻿using UnityEngine;
using System.Collections;

public class MenuBG_Scroll : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSizeZ;

	private Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;
	}

	void Update ()
	{
	//	float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		float newPosition = Mathf.PingPong(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPosition + Vector3.down * newPosition;
	}
}