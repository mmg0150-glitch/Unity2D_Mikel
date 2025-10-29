using System;
using TMPro;
using UnityEngine;

public class ContadorMuertes : MonoBehaviour
{
    public TMP_Text textoContador;
    public GameObject mensajeFinal; // Nuevo para mostrar el mensaje de partida finalizada
    public int muertesObjetivo = 4;


    private int muertes = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActualizarTexto();
        if (mensajeFinal != null)
            mensajeFinal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SumaMuerte()
    {

        muertes++;
        ActualizarTexto();

        if (muertes >= muertesObjetivo)
            MostrarMensajeFinal();
    }

    private void ActualizarTexto()
    {

        textoContador.text = "Muertes: " + muertes;

    }

    private void MostrarMensajeFinal()
    {

        if (mensajeFinal != null)
            mensajeFinal.SetActive(true);

    }

    public void SumarMuerte()
    {
        muertes++;
        ActualizarTexto();
        if (muertes >= muertesObjetivo)
            MostrarMensajeFinal();
    }

}
