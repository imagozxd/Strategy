using UnityEngine;

public class SpellQ_Zoe : ISkill
{
    [SerializeField] private float _distance;

    public SpellQ_Zoe(float distance)
    {
        _distance = distance;
    }

    public void Execute()
    {
        float damage = 50 + _distance * 2; // Daño escalado con la distancia
        Debug.Log("Pegar Q desde lejos");
    }
}


