//s213422204 Jacques Bosman 08-03

using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
	//source videos hypershade mouse look tutorial

	public enum RotationAxis {MouseX = 1, MouseY = 2}

	public RotationAxis RotXY = RotationAxis.MouseX | RotationAxis.MouseY;
	
	// X axis
	public float SensitivityX = 400f;

	public float MinimumX = -360f;
	public float MaximumX = 360f;

	private float RotationX = 0f;

	private float currentRotationX;
	private float xRotationV;

	// Y axis	
	public float SensitivityY = 400f;

	public float MinimumY = -50f;
	public float MaximumY = 50f;
	
	private float RotationY = 0f;

	private float currentRotationY;
	private float yRotationV;

	public float lookSmoothDamp = 0.1f;

	public Quaternion OriginalRotation;
	
	// Use this for initialization
	void Start () 
	{
		OriginalRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () 
	{


		if(RotXY == RotationAxis.MouseX)
		{
			RotationX += Input.GetAxis("Mouse X") * SensitivityX * Time.deltaTime;
			//RotationX = ClampAngle (RotationX, MinimumX, MaximumX);
			currentRotationX = Mathf.SmoothDamp (currentRotationX, RotationX,ref xRotationV, lookSmoothDamp);
			Quaternion xQuaternion = Quaternion.AngleAxis(currentRotationX, Vector3.up);
			transform.localRotation = OriginalRotation * xQuaternion;
		}

		if(RotXY == RotationAxis.MouseY)
		{
			RotationY -= Input.GetAxis("Mouse Y") * SensitivityY * Time.deltaTime;
			RotationY = ClampAngle (RotationY, MinimumY, MaximumY);
			currentRotationY = Mathf.SmoothDamp (currentRotationY, RotationY,ref yRotationV, lookSmoothDamp);
			Quaternion yQuaternion = Quaternion.AngleAxis(currentRotationY, Vector3.right);
			transform.localRotation = OriginalRotation * yQuaternion;
		}
	}

	public static float ClampAngle(float Angle, float Min, float Max)
	{
		if(Angle < -360)
		{
			Angle += 360;
		}

		if(Angle > 360)
		{
			Angle -= 360;
		}

		return Mathf.Clamp (Angle, Min, Max);
	}
}


//own exploration
//View/Camera rotation using mouse x & y axes (has unwanted curve vertically and horizontally)
//		if(Input.GetAxis("Mouse X") > 0)
//			PlayerView.transform.Rotate(Vector3.down);
//		if(Input.GetAxis("Mouse X") < 0)
//			PlayerView.transform.Rotate (Vector3.up);
//		if(Input.GetAxis("Mouse Y") > 0)
//			PlayerView.transform.Rotate(Vector3.right);
//		if(Input.GetAxis("Mouse Y") < 0)
//			PlayerView.transform.Rotate (Vector3.left);

//Still has curve
//		if(Input.GetAxis("Mouse Y") < 0)
//			PlayerView.transform.Rotate(Vector2.right);
//		if(Input.GetAxis("Mouse Y") > 0)
//			PlayerView.transform.Rotate (-(Vector2.right));
//		if(Input.GetAxis("Mouse X") < 0)
//			PlayerView.transform.Rotate(Vector2.up);
//		if(Input.GetAxis("Mouse X") > 0)
//			PlayerView.transform.Rotate (-(Vector2.up));

