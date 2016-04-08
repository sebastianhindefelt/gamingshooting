using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	public Transform Leader;
	public float AISpeed = 10;
	public float MinDistance = 2;
	// Use this for initialization
	void Start () {
	
		Leader = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (Leader);
		AI ();
	}
	void AI(){
		if (Vector3.Distance (transform.position, Leader.position) >= MinDistance) {
			transform.position += transform.forward * AISpeed * Time.deltaTime;
		}
	}
}
