using UnityEngine;

public class Exercicio003 : MonoBehaviour
{
    [SerializeField] int manaTotal = 100;
    private int precoBolaDeFogo = 30;
    private int precoRaioEletrico = 20;
    private int precoEscudoMagico = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int manaFinal = manaTotal - precoBolaDeFogo - precoEscudoMagico - precoRaioEletrico;

        print(manaFinal);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
