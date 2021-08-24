using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickTrigger : MonoBehaviour
{
	[SerializeField] UnityEvent action;
	private void OnMouseDown() {
		action.Invoke();
	}
}
