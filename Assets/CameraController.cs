using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private GameObject player;
	public float distance;

	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<PlayerController> ().gameObject;
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 posToSee = new Vector3 (player.transform.position.x,distance*player.transform.localScale.y,player.transform.position.z-distance*player.transform.localScale.y);
		transform.position = Vector3.Lerp (transform.position, posToSee, 1);
	}
}
