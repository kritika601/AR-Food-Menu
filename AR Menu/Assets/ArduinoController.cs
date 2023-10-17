using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoController : MonoBehaviour {
  SerialPort arduino;

  void Start () {
    arduino = new SerialPort ("COM9", 9600);
    arduino.Open ();
  }
  
  void Update () {
    if (arduino.IsOpen) {
      if (Input.GetKey ("1")) {
        arduino.Write ("1");
        Debug.Log (1);
      } 
      else if (Input.GetKey ("2")) {
        arduino.Write ("2");
        Debug.Log (2);
      }

      else if (Input.GetKey ("3")) {
        arduino.Write ("3");
        Debug.Log (3);
      }

      else if (Input.GetKey ("4")) {
        arduino.Write ("4");
        Debug.Log (4);
      }
      
    }
  }
}