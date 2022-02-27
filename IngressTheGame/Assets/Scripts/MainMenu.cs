using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
	public AudioMixer audioMixer;

	private void Start()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}
	public void playGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void quitGame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}

	public void setVolume(float volume)
	{
		audioMixer.SetFloat("Volume", volume);
	}
}
