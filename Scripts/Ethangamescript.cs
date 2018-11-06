using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ethangamescript : MonoBehaviour {
    public Text textoPoder;
    public static int poderDisparo = 1;

	// Use this for initialization
	void Start () {
        GameController.onAumentarpoder += poder;
        textoPoder.text = "Poder: " + poderDisparo.ToString() + "\n Dinero: " + GameController.dinero.ToString();
	}

    void poder(int cantidad) {
        poderDisparo += cantidad;
        Debug.Log(poderDisparo);
        textoPoder.text = "Poder: " + poderDisparo.ToString() + "\n Dinero: " + GameController.dinero.ToString();
    }
}
