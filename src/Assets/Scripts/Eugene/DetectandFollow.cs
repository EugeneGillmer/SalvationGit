using UnityEngine;
using System.Collections;

public class DetectandFollow : MonoBehaviour {


    public int moveSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnTriggerStay(Collider thing)
    {
        if (thing.tag == "Player")
            transform.position = Vector3.MoveTowards(transform.position, thing.transform.position, moveSpeed * Time.deltaTime);
    }
}
