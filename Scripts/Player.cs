using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject pink;
	public GameObject red;
	public GameObject yellow;
	public GameObject blue;
	public GameObject darkblue;
	public GameObject green;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Jump"))
		{
			if(pink.activeSelf)
			{
				pink.transform.GetComponent<Animator>().SetTrigger("shoot");
			}
			else
			if(red.activeSelf)
			{
				red.transform.GetComponent<Animator>().SetTrigger("shoot");
			}
			else
			if(blue.activeSelf)
			{
				blue.transform.GetComponent<Animator>().SetTrigger("shoot");
			}
			else
			if(green.activeSelf)
			{
				green.transform.GetComponent<Animator>().SetTrigger("shoot");
			}
			else
			if(yellow.activeSelf)
			{
				yellow.transform.GetComponent<Animator>().SetTrigger("shoot");
			}
			else
			if(darkblue.activeSelf)
			{
				darkblue.transform.GetComponent<Animator>().SetTrigger("shoot");
			}
		}
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.name.Equals("pinkc"))
		{
			deactiveAll();
			pink.SetActive(true);

		}else
		if(other.name.Equals("bluec"))
		{
			deactiveAll();
			blue.SetActive(true);
			
		}else
		if(other.name.Equals("darkbluec"))
		{
			deactiveAll();
			darkblue.SetActive(true);
			
		}else
		if(other.name.Equals("greenc"))
		{
			deactiveAll();
			green.SetActive(true);
			
		}else
		if(other.name.Equals("redc"))
		{
			deactiveAll();
			red.SetActive(true);
			
		}else
		if(other.name.Equals("yellowc"))
		{
			deactiveAll();
			yellow.SetActive(true);
			
		}
	}

	void deactiveAll()
	{
		pink.SetActive(false);
		blue.SetActive(false);
		darkblue.SetActive(false);
		green.SetActive(false);
		red.SetActive(false);
		yellow.SetActive(false);
	}
}
