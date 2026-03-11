using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    [SerializeField] int pontosBase;
    [SerializeField] int inimigosDerrotados;
    [SerializeField] int bonus;
    void Start()
    {
        int pontuacaoFinal = pontosBase * inimigosDerrotados + bonus;
        print(pontuacaoFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
