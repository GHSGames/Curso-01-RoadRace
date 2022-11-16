using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeiculoController : MonoBehaviour
{
    public ButtonScript botaoEsquerdo;
    public ButtonScript botaoDireito;
    private bool irParaEsquerda = false;
    private bool irParaDireita = false;
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

        if (!this.botaoEsquerdo.presionando && !this.precionandoEsquerda) {
            this.irParaEsquerda = false;
        }

        if (!this.botaoDireito.presionando && !this.precionandoDireita) {
            this.irParaDireita = false;
        }

        if (this.precionandoEsquerda || this.botaoEsquerdo.presionando) {
            this.irParaEsquerda = true;
        }

        if (this.precionandoDireita || this.botaoDireito.presionando) {
            this.irParaDireita = true;
        }

        if (this.irParaEsquerda) {
            transform.rotation = Quaternion.Euler(0, -30, 0);
        }

        if (this.irParaDireita) {
            transform.rotation = Quaternion.Euler(0, 30, 0);
        }

        if ((!this.irParaEsquerda && !this.irParaDireita) || (irParaEsquerda && irParaDireita)) {
             transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
