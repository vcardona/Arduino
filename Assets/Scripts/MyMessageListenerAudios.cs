using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyMessageListenerAudios : MonoBehaviour
{

    public AudioClip[] AudiosBotones;

    public AudioSource m_MyAudioSource;

    public string NombreEscena;

    private void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();

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
                SceneManager.LoadScene(NombreEscena);
                Debug.Log("Parte Blue del Switch");
                break;
            case 2:
                m_MyAudioSource.clip = AudiosBotones[0];
                m_MyAudioSource.Play();
                Debug.Log("Parte Red del Switch");
                break;
            case 3:
                m_MyAudioSource.clip = AudiosBotones[1];
                m_MyAudioSource.Play();
                Debug.Log("Parte Green del Switch");
                break;
            case 4:
                m_MyAudioSource.clip = AudiosBotones[2];
                m_MyAudioSource.Play();
                Debug.Log("Parte Yellow del Switch");
                break;
        }
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
