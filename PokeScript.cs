using UnityEngine;
using System.Collections;

public class PokeScript : MonoBehaviour {

	public float force;
	void OnMouseDown()
	{
		GetComponent<Rigidbody> ().AddForce (new Vector3(-120,20,100), ForceMode.Impulse);	
		Debug.Log("tja");
	}
	}
