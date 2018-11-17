using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	
	// Use this for initialization
	void Start () {
		
	}

// Update is called once per frame


	void Update ()
	{
			Vector3 vec3 = this.transform.eulerAngles;
			vec3.y += 20 * Time.deltaTime;
			vec3.x %= 360;
			this.transform.eulerAngles = vec3;
		
	}

}
