using UnityEngine;

public class ExercicioS4E10 : MonoBehaviour
{
    private float tempo = 120f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        --tempo;
        if (tempo <= 0)
        {
            print("Tempo esgotado");
        }
        else
        {
            print(tempo);
        }
    }
}
