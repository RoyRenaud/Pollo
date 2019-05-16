using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartIfFall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.z < 8 && transform.position.y <= -10)
        {
            transform.position = new Vector3(0f, 10f, 0f);
        } else if (transform.position.x < 22 && transform.position.z < 47 && transform.position.y <= -10)
        {
            transform.position = new Vector3(12f, 5f, 22f);
        } else if (transform.position.x > 1 && transform.position.z > 45  && transform.position.y <= -10)
        {
            transform.position = new Vector3(12f, 15f, 48f);
        } else if (transform.position.x > 22 && transform.position.z < 47 && transform.position.y <= -10)
        {
            transform.position = new Vector3(29f,30f,50f);
        }
        
       

    }
}
