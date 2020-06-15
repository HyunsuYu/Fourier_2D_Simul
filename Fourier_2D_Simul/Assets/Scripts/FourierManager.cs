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

    private float timer;
    private int counter = 0;
    private int repeatNum = 10;

    Fourier_2D_SimulDll.Fourier_2D_Simul fourier;

    void Start()
    {
        fourier = new Fourier_2D_Simul(new Fourier_2D_Simul.InputPack(25, 25, 15, 5, 5, 0.001, circle, vector, node, dot));
        //for(int i = 0; i < 1000; i++)
        //{
        //    fourier.MakeFourier();
        //}

        InvokeRepeating("temp", 0.0f, 0.1f);
    }

    private void temp()
    {
        fourier.MakeFourier();
    }
}
