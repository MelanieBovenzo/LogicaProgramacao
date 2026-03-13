using UnityEngine;

public class Exercicio005 : MonoBehaviour
{
    [SerializeField] int moedasBronze = 12;
    [SerializeField] int moedasPrata = 8;
    [SerializeField] int moedasOuro = 3;

    [SerializeField] int valorBronze = 1;
    [SerializeField] int valorPrata = 5;
    [SerializeField] int valorOuro = 10;
    void Start()
    {
        print(moedasBronze * valorBronze + moedasPrata * valorPrata + moedasOuro * valorOuro);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
