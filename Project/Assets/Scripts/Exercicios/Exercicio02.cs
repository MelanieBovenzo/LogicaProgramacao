using UnityEngine;
using UnityEngine.Video;

public class Exercicio02 : MonoBehaviour
{
    private int vida = 100;
    private int dano = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vida -= dano;
        // vida = vida - dano;
        print(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
