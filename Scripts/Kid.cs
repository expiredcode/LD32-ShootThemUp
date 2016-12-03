using UnityEngine;
using System.Collections;

public class Kid : MonoBehaviour {

	public bool cry = false;
	public bool dontcry=true;

	AudioSource a;

	GameObject c,b;

	float startcrying=0;

	private float delta = 0;

	// Use this for initialization
	void Start () {

		startcrying = Random.Range(5,100);

		a = GetComponent<AudioSource>();
		a.volume=0.2f;
		c = transform.Find("c").gameObject;
		b = transform.Find("baloon").gameObject;
		b.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {

		delta+=Time.deltaTime;

		/*if(dontcry==false)
		{
			Metti ();
			dontcry = true;
		}*/

		if(!cry)
		if(delta>startcrying)
		{
			a.Play();
			c.SetActive(false); 
			b.SetActive(true);
			cry=true;
			dontcry = true;
		}
	
	}

	public void FFFUUU()
	{
		//Debug.Log("FFFFFFFFFFFFFFFFFUUUUUUUU");
	}

	/*void OnCollisionEnter(Collision collisionInfo)
	{Debug.Log("colli!");
		Metti();
	}
	void OnTriggerEnter(Collider other) 
	{Debug.Log("trigghi!");
		Metti();
		FFFUUU();
	}*/
	
	public void Metti()//void OnTriggerEnter(Collider other) 
	{
		//Debug.Log("metti?"+transform.name);

	/*	if(cry)
		{*/
			a.Stop();
			//transform.Find("c").gameObject.SetActive(true);
			if(!c.activeSelf)
			{
				c.SetActive(true);
				b.SetActive(false);
			}			
			//else
			//	Debug.Log("highasfuckhere");
			cry=false;
			delta=0;
			startcrying = Random.Range(5,100);
		//}

	}

}
