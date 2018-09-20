using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIStay : MonoBehaviour
{
	
	public Transform Destination;
	private NavMeshAgent agent;
	public Transform PostPoint;
	private Transform finalDestination;
	public FloatData Speed;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.speed = Speed.Value;
		finalDestination = transform;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if (obj.transform == Destination)
		finalDestination = Destination;
	}

	private void OnTriggerExit(Collider obj)
	{
		finalDestination = PostPoint;
	}

	private void Update()
	{
		agent.destination = finalDestination.position;
	}



}
