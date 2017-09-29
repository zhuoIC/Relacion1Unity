using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	float contadorX = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (transform.rotation.x + contadorX, transform.rotation.y, transform.rotation.z));
	}
}
