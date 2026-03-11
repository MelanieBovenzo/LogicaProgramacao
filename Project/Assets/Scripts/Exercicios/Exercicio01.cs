using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    [SerializeField] private int a, b;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("soma de a e b: " + (a + b));
    }

}
