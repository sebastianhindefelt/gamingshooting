using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
	public GameObject ball;
	public float heightView, distanceView;
	// Use this for initialization
	void Start () {
		

	    
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = ball.transform.position;
		newPos.y += heightView;
		newPos.z += distanceView;
		transform.position = newPos;
		transform.LookAt (ball.transform.position);
	}
}
