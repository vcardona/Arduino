using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyMessageListenerSecond : MonoBehaviour 
{
    
    public string[] nombreEscena;

    private void Start()
    {


    }

    public void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
        Debug.Log(msg);
        CambioColor(msg);

    }

    public void CambioColor(string clave)
    {
        Debug.Log("Función Cambio Color");
        Debug.Log("El mensaje que llego es " + clave);

        int valorEntero = int.Parse(clave);

        switch (valorEntero)
        {
            case 1:
                SceneManager.LoadScene(nombreEscena[3]);
                Debug.Log("Parte Blue del Switch");
                break;
            case 2:
                SceneManager.LoadScene(nombreEscena[0]);
                Debug.Log("Parte Red del Switch");
                break;
            case 3:
                SceneManager.LoadScene(nombreEscena[1]);
                Debug.Log("Parte Green del Switch");
                break;
            case 4:
                SceneManager.LoadScene(nombreEscena[2]);
                Debug.Log("Parte Yellow del Switch");
                break;
        }
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
