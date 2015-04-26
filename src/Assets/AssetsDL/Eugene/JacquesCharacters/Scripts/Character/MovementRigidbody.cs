//s213422204 Jacques Bosman 26-02

using UnityEngine;
using System.Collections;

public class MovementRigidbody : MonoBehaviour 
{
	public float walkingSpeed;
	public float sprintSpeed;
	public float jumpHeight;
	public float mouseSensitivity;
    public GameObject PlayerBody;
	private Rigidbody PlayerRb;
	private Collider PlayerCol;
	private Collider TerrainCol;
	public float distToGround;
	public float distToWall;

	// Use this for initialization
	void Start () 
	{
        //PlayerBody = GameObject.Find ("First Person Controller");
		PlayerRb = this.GetComponent<Rigidbody>();
		PlayerCol = this.GetComponent<CapsuleCollider>();
		TerrainCol = GetComponent<TerrainCollider>();
		PlayerRb.freezeRotation = true;
		distToGround = PlayerCol.bounds.extents.y;
		//distToWall = PlayerCol.bounds.extents.z;
	}
	
	//Update is called once per frame
//	void Update () 
//	{
//
//	}

	public bool IsGrounded()
	{
		return( Physics.Raycast (PlayerBody.transform.position, -Vector3.up, distToGround + 0.2f));
	}

	public bool IsWalled()
	{
		return( Physics.Raycast (PlayerBody.transform.position, Vector3.forward, distToWall + 0.2f));
	}

	// Update is called once per 0.02sec & for physics
	void FixedUpdate () 
	{
		//Keybord movement using rigidbody and addforce method
		if(Input.GetKey ("left shift") && Input.GetKey ("w"))
			PlayerRb.AddForce( transform.forward * sprintSpeed, ForceMode.Acceleration);
		else if(Input.GetKey ("w"))
			PlayerRb.AddForce( transform.forward * walkingSpeed, ForceMode.Force);
		if(Input.GetKey ("s"))
			PlayerRb.AddForce( -transform.forward * walkingSpeed, ForceMode.Force);
		if(Input.GetKey ("a"))
			PlayerRb.AddForce( -transform.right * walkingSpeed, ForceMode.Force);
		if(Input.GetKey ("d"))
			PlayerRb.AddForce( transform.right * walkingSpeed, ForceMode.Force);
		if(Input.GetKey ("space") && IsGrounded ())
            PlayerRb.velocity = transform.TransformDirection(0, jumpHeight, 0);

		if(!IsGrounded())
		{
			PlayerRb.AddForce ( -transform.up * 9.8f, ForceMode.Force);
		}
	}
}

//look Still has curve(should still try to seperate x & y axis on different objects like with other mouse look script
//		if(Input.GetAxis("Mouse Y") < 0)
//			PlayerView.transform.Rotate(Vector2.right * Time.deltaTime);
//		if(Input.GetAxis("Mouse Y") > 0)
//			PlayerView.transform.Rotate (-(Vector2.right) * Time.deltaTime);
//		if(Input.GetAxis("Mouse X") < 0)
//			PlayerView.transform.Rotate(Vector2.up * Time.deltaTime);
//		if(Input.GetAxis("Mouse X") > 0)
//			PlayerView.transform.Rotate (-(Vector2.up) * Time.deltaTime);


//movement direction doesnt include rotation.
//		if(Input.GetKey ("left shift") && Input.GetKey ("w"))
//			PlayerRb.AddForce( new Vector3(0, 0, sprintSpeed * Time.deltaTime), ForceMode.Acceleration);
//		if(Input.GetKey ("w"))
//			PlayerRb.AddForce( new Vector3(0, 0, walkingSpeed * Time.deltaTime), ForceMode.Acceleration);
//		if(Input.GetKey ("s"))
//			PlayerRb.AddForce( new Vector3(0, 0, -walkingSpeed * Time.deltaTime), ForceMode.Force);
//		if(Input.GetKey ("a"))
//			PlayerRb.AddForce( new Vector3(-walkingSpeed * Time.deltaTime, 0, 0), ForceMode.Force);
//		if(Input.GetKey ("d"))
//			PlayerRb.AddForce( new Vector3(walkingSpeed * Time.deltaTime, 0, 0), ForceMode.Force);
//		if(Input.GetKeyDown ("space") && this.transform.position.y == 1)
//			PlayerRb.AddForce ( new Vector3(0, jumpHeight * Time.deltaTime,0), ForceMode.Impulse);

//Less precise way of movement
//		if(Input.GetKey ("w"))
//			PlayerRb.AddForce( transform.forward * walkingSpeed, ForceMode.Force);
//		if(Input.GetKey ("s"))
//			PlayerRb.AddForce( transform.forward *  -walkingSpeed, ForceMode.Force);
//		if(Input.GetKey ("a"))
//			PlayerRb.AddForce( transform.right * -walkingSpeed, ForceMode.Force);
//		if(Input.GetKey ("d"))
//			PlayerRb.AddForce( transform.right * walkingSpeed, ForceMode.Force);

