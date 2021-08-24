using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MonstersCountController : MonoBehaviour
{
	public static int monstersCount = 0;
	public static int score = 0;
	[SerializeField] int maxOnField = 10;
	[SerializeField] UnityEvent ifGreater;
	[SerializeField] Text scoreText;

	public static void AddMonster() {
		monstersCount++;
	}

	public static void DeleteMonster() {
		monstersCount--;
		score++;
	}

	private void Update() {
		if (monstersCount > maxOnField ) {
			ifGreater.Invoke();
		}
		scoreText.text = score.ToString();
	}
}
