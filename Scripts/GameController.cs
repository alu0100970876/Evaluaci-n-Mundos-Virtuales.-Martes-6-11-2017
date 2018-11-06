using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static int dinero = 30;   // dinero para comprar energia

    public delegate void aumentarPoder(int cantidad); // script para aumentar el poder del jugador
    public static aumentarPoder onAumentarpoder;

    public delegate void disminuirPoder(int cantidad); // script para disminuir el pdoer
    public static disminuirPoder onDisminuirpoder;

    public delegate void disparoTipoB();        // script para disparar a lso objetos tipo b
    public static disparoTipoB onDisparotipoB;

    public void compraPoder() { // esta función es llamada por el botón de comprar poder y su "Event manager"
        if (dinero >= 20)
        {
            dinero = dinero - 20;
            onAumentarpoder(1);
        }
    }

    void Update() {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            onDisminuirpoder(Ethangamescript.poderDisparo);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            onDisparotipoB();
            dinero += 10;
        }
    }

}
