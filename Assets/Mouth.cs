using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour {
	public float damange;

	void OnTriggerEnter(Collider other) {
		other.GetComponent<Damageable> ().damange (damange * transform.localScale.magnitude);
		//GetComponentInParent<Body> ().growUp (other.transform.localScale.magnitude);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
