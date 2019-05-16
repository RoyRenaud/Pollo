using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gomenu : MonoBehaviour {
    
	public void goMenu () {
        SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
	}
	
	
}
