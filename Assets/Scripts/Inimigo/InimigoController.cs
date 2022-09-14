using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoController : MonoBehaviour
{
    public Material[] cores;
    public float rageMinimoVelocidade = 5.0f;
    public float rageMaximoVelocidade = 10.0f;
    private float velocidade;


    void Start()
    {
       MudaVelocidadeECor();
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, this.velocidade * -1 * Time.deltaTime));
    }

    private void teleportaInimigo() {
        Vector3 posicao = new Vector3(
          gameObject.transform.position.x,
          gameObject.transform.position.y,
          50
        );
        gameObject.transform.position = posicao;
        gameObject.transform.GetComponentInChildren<PontuaController>().zerar();
    }

    private void OnCollisionEnter(Collision c) {
        if(c.gameObject.tag == "TeleportaInimigo") {
            MudaVelocidadeECor();
            teleportaInimigo();
        }
    }

    private void MudaVelocidadeECor() {
        for (int i = 0; i < gameObject.transform.childCount; i++) {
            Transform inimigo = gameObject.transform.GetChild(i);
            if (inimigo.tag == "PlaneInimigo") {
                int posicao = Random.Range(0, cores.Length);
                inimigo.GetComponent<Renderer>().material = cores[posicao];
            }
       }
       this.velocidade = Random.Range(rageMinimoVelocidade, rageMaximoVelocidade);
    }
}
