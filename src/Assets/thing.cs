using UnityEngine;
using System.Collections;

public class thing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.T))
        {
            this.GetComponent<Animation>().Play();
        }
	}


}
