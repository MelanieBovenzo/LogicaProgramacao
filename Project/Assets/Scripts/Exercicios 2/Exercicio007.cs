using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio007 : MonoBehaviour
{
    [SerializeField] int vida = 150;
    [SerializeField] int dano1 = 20;
    [SerializeField] int dano2 = 35;
    [SerializeField] int dano3 = 15;
    void Start()
    {
        vida = vida - dano1 - dano2 - dano3;

        print(vida);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
