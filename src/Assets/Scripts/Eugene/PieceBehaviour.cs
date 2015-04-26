using UnityEngine;
using System.Collections;

public class PieceBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionStay(Collision thing)
    {
        if (thing.gameObject.tag == "Piece")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    void OnCollisionExit(Collision thing)
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
