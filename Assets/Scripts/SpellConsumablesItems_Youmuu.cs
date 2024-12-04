using System.Collections;
using UnityEngine;

public class SpellConsumablesItems_Youmuu : MonoBehaviour,ISkill  //necesario para corrutina
{
    private float _acceleration = 60f;
    private float _buffTime = 5f;
    private float _characterSpeed = 300f;
    public SpellConsumablesItems_Youmuu(float aceeleration, float buffTime)
    {
        _acceleration = aceeleration; 
        _buffTime = buffTime;
    }
    public void Execute()
    {
        Debug.Log("espada fantasma de youmuu !!");
        StartCoroutine(ApplyBuff());
    }

    private IEnumerator ApplyBuff()
    {
        float baseSpeed = _characterSpeed; 
        _characterSpeed = _characterSpeed + baseSpeed;

        yield return new WaitForSeconds(_acceleration); //esperar mientras dura efecto

        _characterSpeed = baseSpeed;
        Debug.Log("se acabo el efecto de youmuu");
        
    }
}

