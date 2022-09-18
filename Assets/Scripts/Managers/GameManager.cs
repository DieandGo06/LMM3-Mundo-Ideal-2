using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //public GameObject suelo;
    //public GameObject paredes;
    public GameObject bebida;

    public GameObject jugador;
    //public PlayerInfo playerInfo;

    //public RawImage corteDeLuz;
    //public GameObject globalVolume;

    private int limiteDeFps = 30;
    public float contadorBebida;
    public float contadorGalletitas;
    public float contadorCereales;
    public float contadorCarne;
    public float contadorGolosinas;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Application.targetFrameRate = limiteDeFps;
        contadorBebida = 3;
        contadorGalletitas = 2;
        contadorCereales = 2;
        contadorCarne = 2;
        contadorGolosinas = 1;

    }
}
