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

    public Vector2Int coord;
    public int vectorNumber;
    public int maxAmplitude;
    public int maxPeriod;
    public double frequency;
    public float speed;

    Fourier_2D_SimulDll.Fourier_2D_Simul fourier;

    void Start()
    {
        fourier = new Fourier_2D_Simul(new Fourier_2D_Simul.InputPack(coord.x, coord.y, vectorNumber, maxAmplitude, maxPeriod, frequency, circle, vector, node, dot));

        InvokeRepeating("temp", 0.0f, speed);
    }

    private void temp()
    {
        fourier.MakeFourier();
    }
}
