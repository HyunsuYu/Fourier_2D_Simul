using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fourier_2D_SimulDll;

public class FourierManager : MonoBehaviour
{
    public GameObject circle;
    public GameObject vector;
    public GameObject node;
    public GameObject dot;

    private GameObject temp;

    Fourier_2D_SimulDll.Fourier_2D_Simul fourier;

    void Start()
    {
        Fourier_2D_Simul fourier = new Fourier_2D_Simul(new Fourier_2D_Simul.InputPack(0, 0, 5, 5, 5, 0.01, circle, vector, node, dot));
        InvokeRepeating("Temp", 0.0f, 1.0f);
    }
    private void Temp()
    {
        fourier.MakeFourier();
    }
}
