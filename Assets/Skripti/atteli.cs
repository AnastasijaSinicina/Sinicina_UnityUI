using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteli : MonoBehaviour {

	public GameObject slaidAug;
	public GameObject slaidplat;
	public GameObject BiksslaidAug;
	public GameObject Biksslaidplat;
	public GameObject KleitslaidAug;
	public GameObject Kleitslaidplat;
	public GameObject AksesslaidAug;
	public GameObject Aksesslaidplat;
	public GameObject ApavislaidAug;
	public GameObject Apavislaidplat;
	public GameObject VaronisslaidAug;
	public GameObject Varonisslaidplat;


	public GameObject varonis;
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
	public GameObject mainigaisAttels2, mainigaisAttels3, mainigaisAttels4, 
	mainigaisAttels5;


    public void krekluAttelosana(bool vertiba){
		krekliIzv.SetActive (vertiba);
		slaidplat.SetActive (vertiba);
		slaidAug.SetActive (vertiba);

	}
	public void biksesAttelosana(bool vertiba){
		biksesIzv.SetActive (vertiba);
		BiksslaidAug.SetActive (vertiba);
		Biksslaidplat.SetActive (vertiba);

	}
	public void apaviAttelosana(bool vertiba){
		apaviIzv.SetActive (vertiba);
		ApavislaidAug.SetActive (vertiba);
		Apavislaidplat.SetActive (vertiba);

	}
	public void aksesAttelosana(bool vertiba){
		aksesIzv.SetActive (vertiba);
		AksesslaidAug.SetActive (vertiba);
		Aksesslaidplat.SetActive (vertiba);

	}
	public void kleitasAttelosana(bool vertiba){
		kleitasIzv.SetActive (vertiba);
		KleitslaidAug.SetActive (vertiba);
		Kleitslaidplat.SetActive (vertiba);


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
		else if (sk == 3)
			mainigaisAttels2.GetComponent<Image>().sprite = dzinsuMasivs[3];
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

	public void Platums()
	{
		float pasreizejaVertiba = slaidplat.GetComponent<Slider> ().value;
		float augs = mainigaisAttels.transform.localScale.y;
		Vector2 newScale = new Vector2 (1f * pasreizejaVertiba, augs);
		mainigaisAttels.transform.localScale = newScale;
	}
	public void Augstums(){
		float pasreizejaVertiba = slaidAug.GetComponent<Slider> ().value;
		float plat = mainigaisAttels.transform.localScale.x;
		Vector2 newScale = new Vector2 (plat, 1f*pasreizejaVertiba);
		mainigaisAttels.transform.localScale = newScale;
	}
	public void PlatumsBikses()
	{
		float pasreizejaVertiba = Biksslaidplat.GetComponent<Slider> ().value;
		float augs = mainigaisAttels2.transform.localScale.y;
		Vector2 newScale = new Vector2 (1f * pasreizejaVertiba, augs);
		mainigaisAttels2.transform.localScale = newScale;
	}
	public void AugstumsBikses(){
		float pasreizejaVertiba = BiksslaidAug.GetComponent<Slider> ().value;
		float plat = mainigaisAttels2.transform.localScale.x;
		Vector2 newScale = new Vector2 (plat, 1f*pasreizejaVertiba);
		mainigaisAttels2.transform.localScale = newScale;
	}
	public void PlatumsKleitas()
	{
		float pasreizejaVertiba = Kleitslaidplat.GetComponent<Slider> ().value;
		float augs = mainigaisAttels3.transform.localScale.y;
		Vector2 newScale = new Vector2 (1f * pasreizejaVertiba, augs);
		mainigaisAttels3.transform.localScale = newScale;
	}
	public void AugstumsKleitas(){
		float pasreizejaVertiba = KleitslaidAug.GetComponent<Slider> ().value;
		float plat = mainigaisAttels3.transform.localScale.x;
		Vector2 newScale = new Vector2 (plat, 1f*pasreizejaVertiba);
		mainigaisAttels3.transform.localScale = newScale;
	}

	public void PlatumsAkses()
	{
		float pasreizejaVertiba = Aksesslaidplat.GetComponent<Slider> ().value;
		float augs = mainigaisAttels4.transform.localScale.y;
		Vector2 newScale = new Vector2 (1f * pasreizejaVertiba, augs);
		mainigaisAttels4.transform.localScale = newScale;
	}
	public void AugstumsAkses(){
		float pasreizejaVertiba = AksesslaidAug.GetComponent<Slider> ().value;
		float plat = mainigaisAttels4.transform.localScale.x;
		Vector2 newScale = new Vector2 (plat, 1f*pasreizejaVertiba);
		mainigaisAttels4.transform.localScale = newScale;
	}

	public void PlatumsApavi()
	{
		float pasreizejaVertiba = Apavislaidplat.GetComponent<Slider> ().value;
		float augs = mainigaisAttels5.transform.localScale.y;
		Vector2 newScale = new Vector2 (1f * pasreizejaVertiba, augs);
		mainigaisAttels5.transform.localScale = newScale;
	}
	public void AugstumsApavi(){
		float pasreizejaVertiba = ApavislaidAug.GetComponent<Slider> ().value;
		float plat = mainigaisAttels5.transform.localScale.x;
		Vector2 newScale = new Vector2 (plat, 1f*pasreizejaVertiba);
		mainigaisAttels5.transform.localScale = newScale;
	}
	public void PlatumsVaronis()
	{
		float pasreizejaVertiba = Varonisslaidplat.GetComponent<Slider> ().value;
		float augs = varonis.transform.localScale.y;
		Vector2 newScale = new Vector2 (1f * pasreizejaVertiba, augs);
		varonis.transform.localScale = newScale;
	}
	public void AugstumsVaronis(){
		float pasreizejaVertiba = VaronisslaidAug.GetComponent<Slider> ().value;
		float plat = varonis.transform.localScale.x;
		Vector2 newScale = new Vector2 (plat, 1f*pasreizejaVertiba);
		varonis.transform.localScale = newScale;
	}
}   