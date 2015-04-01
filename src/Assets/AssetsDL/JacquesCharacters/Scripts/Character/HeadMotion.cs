//s213422204 Jacques Bosman 12-03

using UnityEngine;
using System.Collections;

public class HeadMotion : MonoBehaviour 
{
	public Animation walking;
	public MovementRigidbody movementScript;

	private bool isMoving;
	private bool left;
	private bool right;

	float inputX;
	float inputY;

	// Use this for initialization
	void Start () 
	{
		left = true;
		right = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		inputX = Input.GetAxis("Horizontal");
		inputY = Input.GetAxis("Vertical");

		if(inputX != 0 || inputY != 0)
		{
			isMoving = true;
		}
		else if(inputX == 0 && inputY == 0)
		{
			isMoving = false;
		}

		WalkingAnimation();
	}

	void WalkingAnimation()
	{
		if(isMoving == true && movementScript.IsGrounded())
		{
			if(left == true)
			{
				if(!walking.isPlaying)
				{
					walking.Play("WalkLeft");
					left = false;
					right = true;
				}
			}
			if(right == true)
			{
				if(!walking.isPlaying)
				{
					walking.Play("WalkRight");
					right = false;
					left = true;
				}
			}
		}
	}
}
