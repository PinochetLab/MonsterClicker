using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyIncreaser : MonoBehaviour
{
	float time = 0;
	[SerializeField] float timeParameter = 0.1f;

	private void Update() {
		print(Time.timeScale);
		if (Time.timeScale >= 1f ) {
			time += Time.unscaledDeltaTime;
			Time.timeScale = Mathf.Exp(timeParameter * time);
		}
	}
}
