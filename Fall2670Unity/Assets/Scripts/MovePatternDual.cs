using UnityEngine;
[CreateAssetMenu(fileName = "MovePatternDual")]

public class MovePatternDual : MovePattern
{

	private bool doubleJump;

	public override void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			Move(transform);
			doubleJump = true;
			
				
					if (doubleJump)
					{
						Move(transform);
						doubleJump = false;
					}
					
				
			}

			Move(controller);
		}

	}
