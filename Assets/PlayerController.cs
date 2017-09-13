using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
	private NavMeshAgent navAgent;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		navAgent = GetComponent<NavMeshAgent> ();
	}	

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}

	private void move(Vector3 position){
		navAgent.SetDestination (position);
	}
		
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetMouseButton (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "Terrain") {
					move (hit.point);
				}

			}

		}
	}
}
