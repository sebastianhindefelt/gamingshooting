using UnityEngine;
using System.Collections;

public class FlyCamScript : MonoBehaviour {


		public float moveSpeed = 10f;
		public float turnSpeed = 50f;


		void Update ()
		{
			if(Input.GetKey(KeyCode.UpArrow))
				transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.DownArrow))
				transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

		    if(Input.GetKey(KeyCode.C))
			    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

		    if(Input.GetKey(KeyCode.V))
			    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
		}
	}

