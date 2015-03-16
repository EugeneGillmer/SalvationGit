using UnityEngine;
using System.Collections;

public class TESTFallOffMap : MonoBehaviour {

	public Vector3 current;
	public Vector3 respawn;

	// Use this for initialization
	void Start () {
		respawn = transform.position;
		respawn.y+=10;
	
	}
	
	// Update is called once per frame
	void Update () {
		current = transform.position;
		if (current.y < -10)
			transform.position = respawn;
	}
}
