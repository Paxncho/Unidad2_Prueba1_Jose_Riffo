using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiWorld : MonoBehaviour {

	private string message;
	
    public Text text;

	// Use this for initialization
	void Start () {
        HelloWorld();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HelloWorld() {
        text.text = HolaMundo();
    }
	
	public string HolaMundo(){
        //Me voy a tomar un cafe, que el hola mundo entregue la hora actual y 
        //según la hora, diga buenos días mundo, 
        //buenas tarde o buenas noches		

        int hour = System.DateTime.Now.Hour;

        string message = System.DateTime.Now.ToString("hh:mm:ss tt\n");

        if (hour > 5 && hour < 12)
            message += "Buenos días ";
        else if (hour < 20)
            message += "Buenas tardes ";
        else
            message += "Buenas noches ";

        message += "mundo";

        return message;
	}
}
