using UnityEngine;
using System.Collections;

public class SetColorBlue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().materials[0].color = Color.blue;
	}
}