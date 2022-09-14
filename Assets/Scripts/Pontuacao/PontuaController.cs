using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontuaController : MonoBehaviour
{

    private JogoController jogoController;
    private bool pneuDianteiro = false;
    void Start()
    {
        this.jogoController = GameObject.Find("ControladorDoJogo").GetComponent<JogoController>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision c) {
        if(c.gameObject.tag == "pneuDianteiro") {
           this.pneuDianteiro = true;
        }
        if (c.gameObject.tag == "pneuTraseiro" && this.pneuDianteiro) {
            this.pneuDianteiro = false;
            this.jogoController.Pontuar();
        }
    }

    public void zerar() {
        this.pneuDianteiro = false;
        print("zerou");
    }
}
