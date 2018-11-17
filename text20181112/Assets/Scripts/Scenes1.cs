using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenes1 : MonoBehaviour
{
	public Button Yes;
	public Button btnExit;



	// Use this for initialization
	void Start ()
	{

		Yes.onClick.AddListener(BtnYesOnClick);
		btnExit.onClick.AddListener(BtnExitOnClick);

	}

	private void BtnExitOnClick()
	{
		throw new NotImplementedException();
	}

	public void BtnYesOnClick()
	{
			Application.LoadLevel("Scenes2");
	}

	public void BtnExittOnClick()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		
	
		
	}
}
