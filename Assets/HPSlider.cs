using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSlider : MonoBehaviour
{
	[SerializeField] RectTransform rect;
	[SerializeField] Slider slider;
	[SerializeField] GameObject sliderObject;
	public static HPSlider instance;

	public static Transform target;

	private void Awake() {
		instance = this;
	}
	public static void FixOn(Transform transform) {
		target = transform;
	}

	private void Update() {
		sliderObject.SetActive(target);
		if ( target ) {
			rect.anchoredPosition = Camera.main.WorldToScreenPoint(target.position);
		}
	}

	public static void SetValue(float value) {
		instance.slider.value = value;
	}
}
