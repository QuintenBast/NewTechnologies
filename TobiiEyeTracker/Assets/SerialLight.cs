using UnityEngine;
using System.Collections;
using System.IO.Ports;//.Ports;

public class SerialLight : MonoBehaviour
{


    SerialPort stream = new SerialPort("COM7", 9600); //Set the port (com4) and the baud rate (9600, is standard on most devices)
    float[] lastRot = { 0, 0, 0 }; //Need the last rotation to tell how far to spin the camera

    public float maxValue = 700;
    public float minValue = 200;

    public Transform cameraContainer;

    float currentValue = 0.0f;
    GameObject pointLight;

    void Start()
    {
        pointLight = GameObject.Find("Point light").gameObject;
        stream.Open(); //Open the Serial Stream.
    }

    // Update is called once per frame
    void Update()
    {
        if (stream.IsOpen)
        {
            if (Input.GetKey(KeyCode.Space)) {
                string value = "123";
                stream.WriteLine(value);
            }
        }
    }
}