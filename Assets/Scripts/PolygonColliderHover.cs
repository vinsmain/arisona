﻿using UnityEngine;

public class PolygonColliderHover : MonoBehaviour {

	// Use this for initialization
	private SpriteRenderer spriteRenderer;

	void Start() {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	void OnMouseOver() {
		spriteRenderer.color = Color.yellow;
	}

	void OnMouseExit() {
		spriteRenderer.color = Color.white;
	}
}