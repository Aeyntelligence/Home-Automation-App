using System.IO.Ports;
using UnityEngine;
using UnityEngine.UI;

public class SerialController : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600); // CHANGE COM PORT

    void Start()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.ReadTimeout = 50;
        }
    }

    public void LightOn() => sp.Write("A");
    public void LightOff() => sp.Write("a");
    public void FanOn() => sp.Write("B");
    public void FanOff() => sp.Write("b");

    void OnApplicationQuit()
    {
        if (sp.IsOpen) sp.Close();
    }
}
