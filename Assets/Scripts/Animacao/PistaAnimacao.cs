using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaAnimacao : MonoBehaviour
{
    public GameObject fimDeCursoPista;
    public GameObject fimDeCursoCena;
    public GameObject outraPista;
    private float velocidade = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.fimDeCursoPista.transform.position.z <= this.fimDeCursoCena.transform.position.z) {
            transform.position = new Vector3(0, 0, this.outraPista.transform.position.z + 75.6f);
        }
        transform.Translate(new Vector3(0, 0, this.velocidade * Time.deltaTime * -1));
    }
}
