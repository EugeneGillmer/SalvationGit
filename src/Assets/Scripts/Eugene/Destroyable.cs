using UnityEngine;
using System.Collections;

public class Destroyable : MonoBehaviour {


    public Rigidbody piece;
    int pieceCount, pieceRange;
	
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

            pieceCount = Random.Range(4, 9);

            for (int x = 0; x < pieceCount; x++)
            {
                pieceRange = Random.Range(-6, 7);
                if (pieceRange == 0)
                    pieceRange = 1;

                Rigidbody clone;
                clone = Instantiate(piece, new Vector3(transform.position.x + pieceRange / 2, transform.position.y + pieceRange / 2, transform.position.z + pieceRange / 2), transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(pieceRange*2, (pieceRange+3)*2, pieceRange*2);

                Destroy(clone.gameObject, 5f);
                Debug.Log("Piece Created " + x.ToString() +" of " + pieceCount.ToString());
            }
            
            //disable sight and collision of destroyable;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;

            //destroy gameobject
            Destroy(gameObject, 2f);
        }
    }
}
