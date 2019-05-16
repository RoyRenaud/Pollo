using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LocalIdentity : MonoBehaviour
{
    public NetworkIdentity Identity;
    public basicMovement Movimiento;
    public GameObject Camara;
    
    // Start is called before the first frame update
    void Start()
    {

        Movimiento = GetComponent<basicMovement>();
        Identity = GetComponent<NetworkIdentity>();
        if (!Identity.isLocalPlayer)
        {
            Camara.SetActive(false);
            Movimiento.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
