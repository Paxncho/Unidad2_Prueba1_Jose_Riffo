using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiWorld : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        HelloWorld();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RandomColorText() {
        text.text = Random.ColorHSV().ToString();
    }

    public void HelloWorld() {
        text.text = "Hola Mundo";
    }
}
