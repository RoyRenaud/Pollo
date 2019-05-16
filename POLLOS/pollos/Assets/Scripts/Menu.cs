using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour 
{

	public RectTransform panel1;
	public RectTransform instrucciones;
	public RectTransform creditos;
	public GameObject objetoSonidos;

	public AudioSource sonidos;


	public void Start()
	{
       sonidos = objetoSonidos.GetComponent<AudioSource>();
       creditos.gameObject.SetActive(false);
	    instrucciones.gameObject.SetActive(false);
		panel1.gameObject.SetActive(true);
	}

	public void Jugar()
	{
		sonidos.Play();
		SceneManager.LoadScene("newLVL_one", LoadSceneMode.Single);
	}

	public void Creditos()
	{
		sonidos.Play();
		creditos.gameObject.SetActive(true);
	  instrucciones.gameObject.SetActive(false);
	  panel1.gameObject.SetActive(false);
	}
	
	public void Regresar()
	{
        sonidos.Play();
		panel1.gameObject.SetActive(true);
		creditos.gameObject.SetActive(false);
	  instrucciones.gameObject.SetActive(false);
	}
	public void Instrucciones()
	{
		sonidos.Play();
		instrucciones.gameObject.SetActive(true);
		creditos.gameObject.SetActive(false);
		panel1.gameObject.SetActive(false);

	}
	public void Salir()
	{
		Application.Quit();
	}
}


