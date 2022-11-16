using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float input = 0;
    public float sensibilidade = 3;
    public int numero = 1;
    public bool presionando = false;
    
    void Update()
    {
        if (numero > 0) {
            if (presionando) {
                this.input += Time.deltaTime * sensibilidade;
            } else {
                this.input -= Time.deltaTime * sensibilidade;
            }
            this.input = Mathf.Clamp(this.input, 0, numero);
        } else {
            if (presionando) {
                this.input -= Time.deltaTime * sensibilidade;
            } else {  
                this.input += Time.deltaTime * sensibilidade;
            }
            this.input = Mathf.Clamp(this.input, numero, 0);
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData a) {
        this.presionando = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData a) {
        this.presionando = false;
    }
}
