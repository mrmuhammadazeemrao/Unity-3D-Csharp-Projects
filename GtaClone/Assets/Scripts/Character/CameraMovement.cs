using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	public int speed = 100;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X")<0)
        {
            this.transform.Rotate(speed * Time.deltaTime, 0 ,0 );
        }
        if (Input.GetAxis("Mouse X")>0)
        {
            this.transform.Rotate(-speed * Time.deltaTime, 0 , 0);
        }
	}
}//class
