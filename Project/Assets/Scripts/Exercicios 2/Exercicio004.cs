using Unity.VisualScripting;
using UnityEngine;

public class Exercicio004 : MonoBehaviour
{
    [SerializeField] int tempoParte1 = 12;
    [SerializeField] int tempoParte2 = 18;
    [SerializeField] int tempoParte3 = 9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int tempoTotal = tempoParte1 + tempoParte2 + tempoParte3;

        print(tempoTotal);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
