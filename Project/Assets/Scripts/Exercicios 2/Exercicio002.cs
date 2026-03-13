using System;
using UnityEngine;

public class Exercicio002 : MonoBehaviour
{
    [SerializeField] int danoBase = 15;
    [SerializeField] int bonusFixo = 5;
    [SerializeField] int bonusMultiplicador = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int danoTotal = (danoBase + bonusFixo) * bonusMultiplicador;

        print(danoTotal);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
