using UnityEngine;

public class ExercicioS4E9 : MonoBehaviour
{
    [SerializeField] private int moedas = 50;
    void Start()
    {
        if (moedas >= 100)
        {
            print("pode comprar item");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
