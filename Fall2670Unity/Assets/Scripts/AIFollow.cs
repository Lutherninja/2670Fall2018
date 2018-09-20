using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIFollow : MonoBehaviour
{
	
	public Transform Player;
	private NavMeshAgent agent;
//	public bool CanChase;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

//	private void OnTriggerEnter(Collider other)
//	{
//		CanChase = true;
//	}

//	private void OnTriggerExit(Collider other)
//	{
//		CanChase = false;
//	}

	private void OnTriggerEnter(Collider other)
	{
		agent.destination = Player.position;
	
//		if (CanChase)
//		{
//			agent.destination = Player.position;
//		}
//		else
//		{
//			agent.destination = transform.position;
//		}

		
	}



}