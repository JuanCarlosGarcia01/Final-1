using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{
	void Start()
	{

	}

	void Update()
	{
		if (Input.GetKeyDown("r"))
		{
			SceneManager.LoadScene("Nivel 1");
		}

		if (Input.GetKeyDown("k"))
		{
			SceneManager.LoadScene("Men?");
		}
	}
}
