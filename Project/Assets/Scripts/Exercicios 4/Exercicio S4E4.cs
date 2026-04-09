using UnityEngine;

public class ExercicioS4E4 : MonoBehaviour
{
    private float velocidade = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (velocidade > 10)
        {
            print("Muito rápido!");
        }
        else
        {
            print("Velocidade normal");
        }
    }
}
