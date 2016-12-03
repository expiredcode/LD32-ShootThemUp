using UnityEngine;
using System.Collections;

public class CZitti : MonoBehaviour {

	public GameObject[] culle;
	Kid[] k;

	int i =0,j;

	// Use this for initialization
	void Start () 
	{
		k = new Kid[culle.Length];
		for(j =0;j<culle.Length;j++)
		{
			k[j] = GameObject.Find(culle[j].name).transform.GetComponent<Kid>();
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.gameObject.name.Contains("culla"))
		collisionInfo.gameObject.GetComponent<Kid>().Metti();

	}*/
	/*
	void OnTriggerEnter(Collider other) 
	{
		//other
		//if(other.game .name.Contains("culla"))
		if(other.gameObject.tag == "culla")
		{
			for(j =0;j<culle.Length;j++)
			{
				if(other.name == culle[j].name)
				{
					//GameObject.Find(culle[j].name).transform.GetComponent<Kid>().Metti();
					//culle[j].transform.GetComponent<Kid>().FFFUUU();
					k[j].FFFUUU();

					Debug.Log("AA"+(i++));
				}
			}
			Debug.Log("name"+other.name);

		//	other.transform.Find("c").gameObject.SetActive(true);
				//.Metti();//.dontcry = false;

		}
	}*/
}
