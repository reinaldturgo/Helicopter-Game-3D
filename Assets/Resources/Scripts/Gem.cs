﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// specification
public class Gem : MonoBehaviour
{

	void Start () {

	}

	void Update () {

		if (transform.position.x < -25) {
			Destroy(gameObject);
		}
		else {

			transform.Translate(-SkyscraperSpawner.speed * Time.deltaTime, 0, 0, Space.World);
		}

		transform.Rotate(0, 5f, 0, Space.World);
	}

	void OnTriggerEnter(Collider other) {

		other.transform.parent.GetComponent<HeliController>().PickupGem();
		Destroy(gameObject);
	}
}
