using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class puntaje : MonoBehaviour
{
    float tiempo = 0;
    int elpuntaje = 0;
    [SerializeField] int cantidadDeDigitos;

    string modificarTexto;
    [SerializeField] TMP_Text texto;
    [SerializeField] GameObject jugador;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador.GetComponent<jugador>().Vidas >= 0)
        {
            tiempo += Time.deltaTime;
            elpuntaje = (int)tiempo;


            modificarTexto = elpuntaje.ToString();
            cantidadDeDigitos = modificarTexto.Length;

            texto.text = "Puntaje: ";
            for (int i = 0; i < 9 - cantidadDeDigitos; i++)
            {
                texto.text += "0";
            }
            texto.text += elpuntaje;
        }
        
    }






}
