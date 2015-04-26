using UnityEngine;
using System.Collections;

public class Enable : MonoBehaviour {

	public GameObject thing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			thing.GetComponent<MeshRenderer>().enabled=!thing.GetComponent<MeshRenderer>().enabled;
		}
	}
}
