using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSystem : MonoBehaviour
{
	[SerializeField] float maxHP = 100;
	[SerializeField] GameObject dieEffect;

	float hp = 0;

	private void Start() {
		hp = maxHP;
	}

	public void Hit() {
		HPSlider.FixOn(transform);
		hp -= 35f;
		HPSlider.SetValue(hp / maxHP);
		if ( hp <= 0 ) Die();
	}

	void Die() {
		SoundController.Die();
		Instantiate(dieEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
