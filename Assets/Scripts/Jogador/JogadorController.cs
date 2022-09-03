using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorController : MonoBehaviour
{
    public float velocidade = 10.0f;
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

        if (transform.position.x > -12.12f) {
            if (this.precionandoEsquerda) {
                transform.Translate(new Vector3(this.velocidade * -1 * Time.deltaTime, 0, 0));
            }
        }

        if (transform.position.x < -4) {
            if (this.precionandoDireita) {
                transform.Translate(new Vector3(this.velocidade * 1 * Time.deltaTime, 0, 0));
            }
        }

    }
}
