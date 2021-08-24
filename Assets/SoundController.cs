using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
	public static SoundController instance;
	[SerializeField] AudioSource dieSound;

	private void Awake() {
		instance = this;
	}

	public static void Die() {
		instance.dieSound.Play();
	}
}
