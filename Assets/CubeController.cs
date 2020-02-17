﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	private float speed = -12;
	private float deadLine = -10;
	public AudioClip sound1;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.speed * Time.deltaTime, 0, 0);
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "UnityChan2D"==false) {
			audioSource.PlayOneShot (sound1);
		}
	}
}
