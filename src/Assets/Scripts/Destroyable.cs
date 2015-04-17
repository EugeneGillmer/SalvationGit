using UnityEngine;
using System.Collections;

public class Destroyable : MonoBehaviour {


    public Rigidbody piece;
    public int lifetime = 1;
    public int random;
	
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision thing)
    {
        if (thing.gameObject.tag == "Projectile")
        {
            random = Random.Range(6, 7);

            for (int x = 0; x < random; x++)
            {
                random = Random.Range(-2, 2);
                Rigidbody clone;
                clone = Instantiate(piece, new Vector3(transform.position.x+random,transform.position.y+2,transform.position.z+random), transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(random, 4, random);

                Destroy(clone.gameObject, lifetime);
            }
            //disable sight and collision of destroyable;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(this.gameObject, 2);
        }
    }
}
