using UnityEngine;
public class Zoe
{
    private ISkill _qSkill;
    private ISkill _wSkill;
    private ISkill _eSkill;
    private ISkill _rSkill;

    public void SetQSkill(ISkill skill)
    {
        _qSkill = skill;
    }
    public void SetWSkill(ISkill skill)
    {
        _wSkill = skill;
    }
    public void SetESkill(ISkill skill)
    {
        _eSkill = skill;
    }
    public void SetRSkill(ISkill skill)
    {
        _rSkill = skill;
    }

    public void UseQ()
    {
        if (_qSkill != null)
        {
            _qSkill.Execute();
        }        
    }

    public void UseW()
    {
        if (_wSkill != null)
        {
            _wSkill.Execute();
        }        
    }

    public void UseE()
    {
        if (_eSkill != null)
        {
            _eSkill.Execute();
        }
    }

    public void UseR()
    {
        if (_rSkill != null)
        {
            _rSkill.Execute();
        }
    }
}
