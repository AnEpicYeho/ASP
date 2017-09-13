using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour {
	public float healt;

	// Use this for initialization
	void Start () {
		healt = 100 * transform.localScale.magnitude;
	}

	public void growUp(float amount){
		transform.localScale += new Vector3 (amount,amount,amount);
		healt = 100 * transform.localScale.magnitude;
	}

	void heal (float healAmount){
	}
	
	// Update is called once per frame
	void Update () {
		healt = 100 * transform.localScale.magnitude;
	}
}
