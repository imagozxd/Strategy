using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnController_Zoe : MonoBehaviour
{
    private Zoe zoe;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private int _characterLevel;
    [SerializeField] private float _aceleration = 60f;
    [SerializeField] private float _buffTime = 5f;

    [SerializeField] private Button btnW;

    [SerializeField] private Sprite flash;
    [SerializeField] private Sprite barrier;
    [SerializeField] private Sprite yommou;

    private void Start()
    {
        zoe = new Zoe();

        zoe.SetQSkill(new SpellQ_Zoe(10));
        zoe.SetWSkill(new SpellW_Zoe("Flash"));
        zoe.SetESkill(new SpellE_Zoe());
        zoe.SetRSkill(new SpellR_Zoe());
    }

    public void BtnQ()
    {
        zoe.UseQ();
        textMeshProUGUI.text = "Q lanzada";

    }
    public void BtnW()
    {
        zoe.UseW();
        
    }
    public void BtnE()
    {
        zoe.UseE();
        textMeshProUGUI.text = "E lanzada";

    }
    public void BtnR()
    {
        zoe.UseR();
        textMeshProUGUI.text = "R lanzada";

    }

    public void BtnPickupSpell()
    {
        ISkill[] possibleSpells = {
            new SpellSummoner_Barrier(_characterLevel),
            new SpellSummoner_Flash(),
            new SpellConsumablesItems_Youmuu(_aceleration, _buffTime)
        };

        int randomIndex = Random.Range(0, possibleSpells.Length);
        ISkill chosenSpell = possibleSpells[randomIndex];

        zoe.SetWSkill(chosenSpell);

        UpdateButtonImage(chosenSpell);

        Debug.Log("hechizo de W : " + chosenSpell.GetType().Name);
    }
    private void UpdateButtonImage(ISkill chosenSpell)
    {
        switch (chosenSpell)
        {
            case SpellSummoner_Flash:
                btnW.image.sprite = flash;
                textMeshProUGUI.text = "recogiste flash";
                break;

            case SpellSummoner_Barrier:
                btnW.image.sprite = barrier;
                textMeshProUGUI.text = "recogiste barrera";
                break;

            case SpellConsumablesItems_Youmuu:
                btnW.image.sprite = yommou;
                textMeshProUGUI.text = "recogiste yommou";
                break;
                            
        }
    }
}
