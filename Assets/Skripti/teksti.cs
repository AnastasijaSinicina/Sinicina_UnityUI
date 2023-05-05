using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
using UnityEngine.UI;

public class teksti : MonoBehaviour {

	private string[] fragmentiZens = { " brilles. ", " dzeltenas bikses ", " kreklu ar suni. " };
	private string[] fragmentiMeitene = {"cepuri.", "violetu kleitu ar violetiem apaviem", "dzeltenu kreklu"};

	public GameObject ievadVards;
	public GameObject ievadVecums;
	public GameObject tekstaAttelosana;
	public GameObject Kluda;
	public string vards;
	public int vecums;
	string teksts;
	int ind;

	public void tekstZens(){
		ind = Random.Range (0, fragmentiZens.Length);
		vards = ievadVards.GetComponent<InputField> ().text;
		int x;
		if (!int.TryParse (ievadVecums.GetComponent<InputField> ().text, out x)) {
			Kluda.GetComponent<Text>().text = "Nepareizi ievadīts vecums!";
			return;
		}
		vecums = x;

		tekstaAttelosana.GetComponent<Text>().text = "Sveiki! Mani sauc "+vards+", man ir "+vecums+" gadi.\n"
			+"Skaties, tev ir iespēja izvēlēties kā mani apģērbt. Lūdzu, uztaisi tā, lai meitenem tas patika)\n"
			+"Šodien man gribētos uzvilkt "+fragmentiZens[ind];
	}
	public void tekstMeitene(){
		ind = Random.Range (0, fragmentiMeitene.Length);
		vards = ievadVards.GetComponent<InputField>().text;
		int x;
		if (!int.TryParse (ievadVecums.GetComponent<InputField> ().text, out x)) {
			Kluda.GetComponent<Text>().text = "Nepareizi ievadīts vecums!";
			return;
		}
		vecums = x;
		tekstaAttelosana.GetComponent<Text>().text = "Sveiki! Mani sauc "+vards+", man ir "+vecums+" gadi.\n"
			+"Skaties, tev ir iespēja izvēlēties kā mani apģērbt. Lūdzu, uztaisi tā, lai zēniem tas patika)\n"
			+"Šodien man gribētos uzvilkt "+fragmentiMeitene[ind];
	}





}
