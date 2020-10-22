using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject obj;
    public bool isMove;
    public float Horiz;
    public float Vert;



	// Use this for initialization
	void Awake ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            obj.GetComponent<Animation>().Play("Run");
            Horiz = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            Vert = Input.GetAxis("Vertical") * Time.deltaTime * 10;
            isMove = true;
            this.transform.Rotate(0, Horiz, 0);
            this.transform.Translate(0, 0, Vert);

        }
        else
        {
            obj.GetComponent<Animation>().Play("Idle");
            isMove = false;
        }

	}
}
