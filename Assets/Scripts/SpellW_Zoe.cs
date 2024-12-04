using JetBrains.Annotations;
using UnityEngine;

public class SpellW_Zoe : ISkill
{
    private string _pickupableSpell;

    public SpellW_Zoe(string pickupableSpell)
    {
        _pickupableSpell = pickupableSpell;
    }

    public void Execute()
    {
        Debug.Log("Casting W: Activating "+_pickupableSpell);
    }
}

