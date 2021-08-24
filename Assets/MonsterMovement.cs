using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMovement : MonoBehaviour
{
	NavMeshAgent agent;
	[SerializeField] GameObject appearEffect;

	private void Awake() {
		MonstersCountController.AddMonster();
		agent = GetComponent<NavMeshAgent>();
	}

	private void OnDestroy() {
		MonstersCountController.DeleteMonster();
	}

	private void Start() {
		agent.stoppingDistance = 0.05f;
		transform.position = NewDestination();
		Instantiate(appearEffect, transform.position, Quaternion.identity);
		agent.SetDestination(NewDestination());
	}
	Vector3 NewDestination() {
		Vector2 randomScreenPoint = new Vector2(Random.Range(0f, (float)Screen.width),
			Random.Range(0f, (float)Screen.height));
		Ray ray = Camera.main.ScreenPointToRay(randomScreenPoint);
		if (Physics.Raycast(ray, out RaycastHit hit) ) {
			Vector3 point = hit.point;
			if (NavMesh.SamplePosition(point, out NavMeshHit _hit, 10, LayerMask.NameToLayer("Everything")) ) {
				return (_hit.position);
			}
		}
		return Vector3.zero;
	}

	private void Update() {
		if (agent.remainingDistance < agent.stoppingDistance ) {
			agent.SetDestination(NewDestination());
		}
	}
}
