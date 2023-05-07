using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzika : MonoBehaviour {

	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskanot;
	public AudioSource skanasAvots2;
	public AudioClip skanaKoAtskanot2;
	public AudioSource skanasAvots3;
	public AudioClip skanaKoAtskanot3;
	public AudioSource skanasAvots4;
	public AudioClip skanaKoAtskanot4;
	public AudioSource skanasAvots5;
	public AudioClip skanaKoAtskanot5;



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
		skanasAvots2.PlayOneShot(skanaKoAtskanot2);
	}
	public void kursorsNost2()
	{
		skanasAvots2.Stop();
	}
	public void uzbiditsUzApgerbs()
	{
		skanasAvots3.PlayOneShot(skanaKoAtskanot3);
	}
	public void kursorsNos3()
	{
		skanasAvots3.Stop();
	}
	public void uzbiditsUzMeitene()
	{
		skanasAvots4.PlayOneShot(skanaKoAtskanot4);
	}
	public void kursorsNos4()
	{
		skanasAvots4.Stop();
	}
	public void fonaMusika()
	{
		skanasAvots5.PlayOneShot(skanaKoAtskanot5);
	}
	public void kursorsNos5()
	{
		skanasAvots5.Stop();
	}



}
