using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void OnMouseDown()
	{
		Event.Invoke();
	}
}
