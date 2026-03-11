using UnityEngine;
using UnityEngine.Video;

public class Exercicio08 : MonoBehaviour
{
    [SerializeField] int vida = 100;
    [SerializeField] int dano;
    void Start()
    {
        vida -= dano;
        print(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
