using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraRoda : MonoBehaviour
{
    public float velocidade = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, this.velocidade * -1 * Time.deltaTime));
    }
}
