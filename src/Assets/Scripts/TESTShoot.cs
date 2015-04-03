using UnityEngine;
using System.Collections;

public class TESTShoot : MonoBehaviour {

    public Rigidbody projectile;
    public float upSpd=1,fwdSpd=1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(0, upSpd, fwdSpd);
        }
	}
}
