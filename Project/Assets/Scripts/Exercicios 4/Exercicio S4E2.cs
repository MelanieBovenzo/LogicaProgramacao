using UnityEngine;

public class ExercicioS4E2 : MonoBehaviour
{
    public int vida = 100;
    [SerializeField] private int dano = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            vida -= dano;
            if (vida <= 50)
            {
                print("Cuidado!");
            }
        }
    }
}
