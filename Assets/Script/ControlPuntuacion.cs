using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPuntuacion : MonoBehaviour
{
    private int puntuacion;
    public Text puntuacionTxt;
    // Start is called before the first frame update
    void Start()
    {
        puntuacion= 0;
    }

    public void SumarPuntuacion(int puntos)
    {
        puntuacion += puntos;
        puntuacionTxt.text = puntuacion.ToString();
    }
}
