using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{

	// Use this for initialization
	


	void Update()
    {

     
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(5, 0, 0);
        }
    }
}
