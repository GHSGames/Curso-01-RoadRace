using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeiculoController : MonoBehaviour
{
    private bool precionandoEsquerda = false;
    private bool precionandoDireita = false;

    void Start()
    {
        
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.A)) {
            this.precionandoEsquerda = true;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            this.precionandoDireita = true;
        }

        if (Input.GetKeyUp(KeyCode.A)) {
            this.precionandoEsquerda = false;
        }

        if (Input.GetKeyUp(KeyCode.D)) {
            this.precionandoDireita = false;
        }

        if (this.precionandoEsquerda) {
            transform.rotation = Quaternion.Euler(0, -30, 0);
        }

        if (this.precionandoDireita) {
            transform.rotation = Quaternion.Euler(0, 30, 0);
        }

        if ((!this.precionandoEsquerda && !this.precionandoDireita) || (precionandoEsquerda && precionandoDireita)) {
             transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
