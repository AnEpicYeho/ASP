using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
	private NavMeshAgent navAgent;
	private RaycastHit hit;
	private bool isFollowing;
	private GameObject target;

	// Use this for initialization
	void Start () {
		navAgent = GetComponent<NavMeshAgent> ();
	}	

	private void move(Vector3 position){
		navAgent.SetDestination (position);
		isFollowing = false;
	}

	private void follow(){
		if (target != null) {
			navAgent.SetDestination (target.transform.position);
		} else {
			isFollowing = false;
		}

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(isFollowing){
			follow ();
		}
		
		if (Input.GetMouseButton (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "Terrain") {
					move (hit.point);
				} else {
					isFollowing = true;
					target = hit.transform.gameObject;
				}

			}

		}
	}
}
