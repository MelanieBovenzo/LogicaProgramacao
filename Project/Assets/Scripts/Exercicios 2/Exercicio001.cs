using UnityEngine;

public class Exercicio001 : MonoBehaviour
{
    [SerializeField] int inimigosPequenos = 3;
    [SerializeField] int inimigosMedios = 2;
    [SerializeField] int inimigosChefe = 1;
    private int xpTotal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int xpPequeno = inimigosPequenos * 10;
        int xpMedio = inimigosMedios * 25;
        int xpChefe = inimigosChefe * 100;

        xpTotal = xpPequeno + xpMedio + xpChefe;

        print(xpTotal);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
