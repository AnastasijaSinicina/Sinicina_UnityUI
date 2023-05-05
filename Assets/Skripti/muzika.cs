using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursorsUzAttela : MonoBehaviour {

	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskanot;
	public AudioSource skanasAvots2;
	public AudioClip skanaKoAtskanot2;
	public AudioSource skanasAvots3;
	public AudioClip skanaKoAtskanot3;

	public void uzbiditsUzPoga()
	{
		skanasAvots.PlayOneShot(skanaKoAtskanot);
	}
	public void kursorsNost1()
	{
		skanasAvots.Stop();
	}
	public void uzbiditsUzaJaunu()
	{
		skanasAvots.PlayOneShot(skanaKoAtskanot);
	}
	public void kursorsNost2()
	{
		skanasAvots.Stop();
	}
	public void uzbiditsUzApgerbs()
	{
		skanasAvots.PlayOneShot(skanaKoAtskanot);
	}
	public void kursorsNos3()
	{
		skanasAvots.Stop();
	}
}
