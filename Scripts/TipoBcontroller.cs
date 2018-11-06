using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoBcontroller : MonoBehaviour {
    public delegate void aumentarTamanoA(); // script para aumentar el tamaño de los objetos de tipo A
    public static aumentarTamanoA onAumentartamanoA;

    void Start()
    {
        GameController.onDisparotipoB += disparo;
    }

    void disparo() {
        Color col = new Color(Random.value, Random.value, Random.value);
        this.GetComponent<Renderer>().material.color = col;
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Ethan") {
            onAumentartamanoA();
        }
    }
}
