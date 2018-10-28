using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;//.Ports;


public class Manager : MonoBehaviour {

    public List<Lookable> blocks = new List<Lookable>();
    public List<bool> blockbool = new List<bool>();
    public SpriteRenderer sprite;
    // Use this for initialization

    SerialPort stream = new SerialPort("COM7", 9600); //Set the port (com4) and the baud rate (9600, is standard on most devices)
    float[] lastRot = { 0, 0, 0 }; //Need the last rotation to tell how far to spin the camera

    void Start () {
        stream.Open(); //Open the Serial Stream.
    }
	
	// Update is called once per frame
	void Update () {

		foreach(Lookable block in blocks)
        {
            int i = 0;
            int q = 0;
            if (block.lookedAt)
            {
                blockbool[i] = true;
                i++;
            }
            foreach(bool x in blockbool)
            {
                if(x == true)
                {
                    foreach(Lookable z in blocks)
                    {
                        z.myRenderer.material.color = Color.green;
                        sprite.enabled = true;
                        if (stream.IsOpen)
                        {
                                string value = "123";
                                stream.WriteLine(value);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }

	}
}
