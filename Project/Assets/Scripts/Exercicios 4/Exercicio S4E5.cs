using UnityEngine;

public class ExercicioS4E5 : MonoBehaviour
{
    [SerializeField] private int energia = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (energia < 20)
        {
            print("Sem energia suficiente");
        }
    }
}
