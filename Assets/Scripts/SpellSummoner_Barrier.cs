using UnityEngine;

public class SpellSummoner_Barrier : ISkill
{
    private int _characterLevel;

    public SpellSummoner_Barrier (int characterLevel)
    {
        _characterLevel = characterLevel;
    }

    public void Execute()
    {
        int barrierQuanty = 50 + (_characterLevel * 10);
        Debug.Log("Tirar barrera");
    }
}

