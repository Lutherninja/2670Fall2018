using UnityEngine;


[CreateAssetMenu]
public class MovePattern : ScriptableObject
{
	public FloatData JumpSpeed;
	public FloatData gravity;
	public FloatData RotX, RotY, RotZ;
	public FloatData MoveX, MoveY, MoveZ;
	
	
	
	protected Vector3 moveDirection;
	private Vector3 rotDirection;

	public virtual void Invoke(CharacterController controller, Transform transform)
	{
		
		if (controller.isGrounded)
		{
			Move(transform);
		}

		Move(controller);
		
	}
	

	protected void Move(CharacterController controller)
	{
		moveDirection.y -= gravity.Value * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	protected void Move(Transform transform)
	{
		moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
		moveDirection = transform.TransformDirection(moveDirection);
		rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
		transform.Rotate(rotDirection);
	}
}






