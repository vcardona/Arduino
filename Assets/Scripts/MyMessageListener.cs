using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMessageListener : MonoBehaviour 
{
    public Material[] cantidadMateriales;
    Material m_Material;
    public string ClaveDos;

    private void Start()
    {
        m_Material = GetComponent<Renderer>().material;


    }

    public void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
        Debug.Log(msg);
        CambioColor(msg);



    }

    public void CambioColor(string clave)
    {
        Debug.Log("Función Cambio COlor");
        Debug.Log("El mensaje que llego es " + clave);

        int valorEntero = int.Parse(clave);

        switch (valorEntero)
        {
            case 1:
                m_Material.color = Color.blue;
                iTween.ShakeScale(this.gameObject,new Vector3(0.5f,0.5f,0.5f), 2);
                Debug.Log("Parte Blue del Switch");
                break;
            case 2:
                m_Material.color = Color.red;
                iTween.ShakeScale(this.gameObject, new Vector3(0.5f, 0.5f, 0.5f), 2);
                Debug.Log("Parte Red del Switch");
                break;
            case 3:
                m_Material.color = Color.green;
                iTween.ShakeScale(this.gameObject, new Vector3(0.5f, 0.5f, 0.5f), 2);
                Debug.Log("Parte Green del Switch");
                break;
            case 4:
                m_Material.color = Color.yellow;
                iTween.ShakeScale(this.gameObject, new Vector3(0.5f, 0.5f, 0.5f), 2);
                Debug.Log("Parte Yellow del Switch");
                break;
        }
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
