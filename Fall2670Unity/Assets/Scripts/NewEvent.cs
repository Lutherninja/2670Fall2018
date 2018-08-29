using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//MadeByJonathanLuther
public class NewEvent : MonoBehaviour
{

	public UnityEvent MyEvent;

	private void OnMouseDown()
	{
		MyEvent.Invoke();
	}
}
