using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Sprite[] krekluMasivs;
    public Sprite[] dzinsuMasivs;
    public Sprite[] kleituMasivs;
    public Sprite[] apavuMasivs;
    public Sprite[] aksesuMasivs;
    public GameObject mainigaisAttels;
    public GameObject mainigaisAttels2, mainigaisAttels3, mainigaisAttels4, mainigaisAttels5;


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
    public void izkritosais(int sk)
    {
        if (sk == 0)
            mainigaisAttels.GetComponent<Image>().sprite = krekluMasivs[0];

        else if (sk == 1)
            mainigaisAttels.GetComponent<Image>().sprite = krekluMasivs[1];

        else if (sk == 2)
            mainigaisAttels.GetComponent<Image>().sprite = krekluMasivs[2];
        else
            Debug.Log("Nav piesaistits attels!");
    }
    public void izkritosaisBikses(int sk)
    {
        if (sk == 0)
            mainigaisAttels2.GetComponent<Image>().sprite = dzinsuMasivs[0];

        else if (sk == 1)
            mainigaisAttels2.GetComponent<Image>().sprite = dzinsuMasivs[1];

        else if (sk == 2)
            mainigaisAttels2.GetComponent<Image>().sprite = dzinsuMasivs[2];
        else
            Debug.Log("Nav piesaistits attels!");
    }
    public void izkritosaisKleitas(int sk)
    {
        if (sk == 0)
            mainigaisAttels3.GetComponent<Image>().sprite = kleituMasivs[0];

        else if (sk == 1)
            mainigaisAttels3.GetComponent<Image>().sprite = kleituMasivs[1];

        else
            Debug.Log("Nav piesaistits attels!");
    }
    public void izkritosaisAkses(int sk)
    {
        if (sk == 0)
            mainigaisAttels4.GetComponent<Image>().sprite = aksesuMasivs[0];

        else if (sk == 1)
            mainigaisAttels4.GetComponent<Image>().sprite = aksesuMasivs[1];

        else if (sk == 2)
            mainigaisAttels4.GetComponent<Image>().sprite = aksesuMasivs[2];
        else if (sk == 3)
            mainigaisAttels4.GetComponent<Image>().sprite = aksesuMasivs[3];
        else
            Debug.Log("Nav piesaistits attels!");
    }
    public void izkritosaisApavi(int sk)
    {
        if (sk == 0)
            mainigaisAttels5.GetComponent<Image>().sprite = apavuMasivs[0];

        else if (sk == 1)
            mainigaisAttels5.GetComponent<Image>().sprite = apavuMasivs[1];

        else if (sk == 2)
            mainigaisAttels5.GetComponent<Image>().sprite = apavuMasivs[2];
        else if (sk == 3)
            mainigaisAttels5.GetComponent<Image>().sprite = apavuMasivs[3];
        else
            Debug.Log("Nav piesaistits attels!");
    }

}
