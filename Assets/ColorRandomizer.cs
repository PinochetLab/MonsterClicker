using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
	Color[] colors = new Color[5] {Color.red, Color.blue, Color.green, Color.yellow, Color.magenta };

	private void Start() {
		GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
	}
}
