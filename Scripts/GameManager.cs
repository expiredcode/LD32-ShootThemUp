using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject[] kids;

	public Text text,timer,overtext;

	public GameObject player,over;

	bool a = false;

	int min,sec;
	float delta;

	// Use this for initialization
	void Start () {
		delta = 0;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = ""+(44-CountKids())+"/"+kids.Length+" kids are awake";
		if(!a)
			delta+=Time.deltaTime;

		timer.text = ""+((int)delta);

		if(44-CountKids()>(kids.Length/2))
		{
			player.SetActive(false);
			over.SetActive(true);
			overtext.text = "More than half the room woke up\nYou survived for "+((int)delta)+" seconds.";
			a = true;
		}
	
	}

	int CountKids()
	{
		int count = 1;
		for(int j =0 ;j < kids.Length;j++)
		{
			if(!kids[j].transform.GetComponent<Kid>().cry)
				count+=1;
		}

		return count;
	}
}
