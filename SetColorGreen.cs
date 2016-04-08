using UnityEngine;
using System.Collections;

public class SetColorGreen : MonoBehaviour {
	public float Red = 0.5F;
	public float Green = 0.3F;
	public float Blue = 0.4F;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		//rend.materials[0].color = Color.green;
	}

	 void Update () {

	//	rend.material.shader = Shader.Find ("Specular");
		rend.materials [0].SetColor ("_Color", new Color (Red, Green, Blue, 0.5F));
	}
}
