using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JogoController : MonoBehaviour
{
    public TextMeshProUGUI pontosJogador;
    private int pontos = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pontuar() {
        this.pontos++;
        this.pontosJogador.text = this.pontos.ToString();
    }
}
