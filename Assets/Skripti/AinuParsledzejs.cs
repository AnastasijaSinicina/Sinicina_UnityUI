using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	// metode lauj parslegties no ui ainas uz sakumu
	public void uzSakumu()
	{
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}
	// metode aizvert programmu

	public void Apturet()
	{
		Application.Quit();
	}

	public void uzIzvele()
	{
		SceneManager.LoadScene("Izvele", LoadSceneMode.Single);
	}
	public void uzZens(){
		SceneManager.LoadScene("PR", LoadSceneMode.Single);
}
    public void uzMeitene()
    {
        SceneManager.LoadScene("Meitene", LoadSceneMode.Single);
    }
}