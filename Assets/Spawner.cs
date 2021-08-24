using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] GameObject prefab;
	[SerializeField] float minTime;
	[SerializeField] float maxTime;

	float time = 0;

	private void Update() {
		time -= Time.deltaTime;
		if (time <= 0 ) {
			time = Random.Range(minTime, maxTime);
			Spawn();
		}
	}

	void Spawn() {
		Instantiate(prefab);
	}
}
