using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atteli : MonoBehaviour {

	public GameObject krekli;
	public GameObject krekliIzv;
	public GameObject bikses;
	public GameObject biksesIzv;
	public GameObject apavi;
	public GameObject apaviIzv;
	public GameObject akses;
	public GameObject aksesIzv;
	public GameObject kleitas;
	public GameObject kleitasIzv;


	public void krekluAttelosana(bool vertiba){
		krekliIzv.SetActive (vertiba);
	}
	public void biksesAttelosana(bool vertiba){
		biksesIzv.SetActive (vertiba);
	}
	public void apaviAttelosana(bool vertiba){
		apaviIzv.SetActive (vertiba);
	}
	public void aksesAttelosana(bool vertiba){
		aksesIzv.SetActive (vertiba);
	}
	public void kleitasAttelosana(bool vertiba){
		kleitasIzv.SetActive (vertiba);
	}


}
