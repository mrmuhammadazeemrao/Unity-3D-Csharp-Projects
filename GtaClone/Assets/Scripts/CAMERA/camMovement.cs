using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour {

    public GameObject firstCamera;
    public GameObject secondCamera;
    void Start()
    {
        StartCoroutine(waitForSE());
    }


    IEnumerator waitForSE()
    {
        yield return new WaitForSeconds(5);
        secondCamera.SetActive(true);
        firstCamera.SetActive(false);
    }

}
