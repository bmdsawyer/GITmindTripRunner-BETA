using UnityEngine;
using System.Collections;

public class rotatePill : MonoBehaviour {

	public float spinSpeed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(15,30,15)*spinSpeed*Time.deltaTime);
	}
}
