using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	public float speed = 100;
	private Rigidbody rb;
	public float jumpHeight = 8;
	private bool isFalling = false;
	public float radius = 5.0F;
	public float power =10.0F;
	public float force;
	public float torque;
	void Start(){
		rb = GetComponent<Rigidbody> ();
//		Vector3 explosionPos = transform.position;
//		Collider[] colliders = Physics.OverlapSphere (explosionPos, radius);
//		foreach (Collider hit in colliders) {
//			Rigidbody rb2 = hit.GetComponent<Rigidbody> ();
//
//			if (rb2 != null)
//				rb2.AddExplosionForce (power, explosionPos, radius, 3.0F);
//		}
	}
		void Update () {

		//handles ballrotation
		float sideways = Input.GetAxis("Horizontal") * 10;
		float forward = Input.GetAxis("Vertical") * 10;
		sideways *= Time.deltaTime;
		forward *= Time.deltaTime;
		transform.Translate (0, 0, forward);
		transform.Translate (sideways, 0, 0);
		if (Input.GetKeyDown(KeyCode.Space) && rb.position.y==1){
			rb.velocity = new Vector3 (0, 7, 0);
		
		}
}

	void OnMouseDown ()
	{ 
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100))
			rb.AddForceAtPosition ((transform.position - hit.point) * force, hit.point, ForceMode.Impulse);
	}
}