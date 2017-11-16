using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour {
    public GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        Door.SetActive(false);
        Destroy(this.gameObject);
    }
    
}
