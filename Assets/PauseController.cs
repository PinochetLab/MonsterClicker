using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
	[SerializeField] GameObject pauseWindow;

	void ShowMenu() {
		pauseWindow.SetActive(true);
		Time.timeScale = 0;
	}

	public void HideMenu() {
		pauseWindow.SetActive(false);
		Time.timeScale = 1;
	}

	public void ShowHideMenu() {
		if ( pauseWindow.activeSelf ) HideMenu();
		else ShowMenu();
	}

	public void Restart() {
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu() {
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}
}
