using  System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MovePattern : ScriptableObject
{
	public FloatData jumpSpeed;
	public FloatData gravity;
	public FloatData RotX, RotY, RotZ;
	public FloatData MoveX, MoveY, MoveZ;
	
	
	
	private Vector3 moveDirection;
	private Vector3 rotDirection;

	public void Invoke(CharacterController controller, Transform transform)
	{	if (controller.isGrounded)
		{
			moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
			moveDirection = transform.TransformDirection(moveDirection);
			rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
			transform.Rotate(rotDirection);
				
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed.Value;
            
		}
		moveDirection.y -= gravity.Value * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
	
}






