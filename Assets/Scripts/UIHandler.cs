using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{

	private Text textTitle { get; set; }
	private Text textMessage { get; set; }

	private Button btnYes { get; set; }
	private Text   textYes { get; set; }

	private Button btnNo { get; set; }
	private Text   textNo { get; set; }

	// Use this for initialization
	void Start ()
	{
		int chilCount = this.transform.childCount;
		for (int i = 0; i < chilCount; i++)
		{
			GameObject go = this.transform.GetChild(i).gameObject;
			Debug.Log("chilCount Index = " + i + "Name = " + go.name);

			if (go.name.Equals("Title"))
			{
				textTitle = go.GetComponent<Text>();
			}
		}
		if (textTitle != null)
		{
			textTitle.text = "I M Right";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
