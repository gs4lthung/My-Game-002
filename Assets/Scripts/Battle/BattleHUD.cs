using UnityEngine;
using UnityEngine.UI;
public class BattleHUD : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar hpBar;

    public void SetData(Pokemon pokemon)
    {
        nameText.text = pokemon.Base.PokemonName;
        levelText.text = "Lvl " + pokemon.Level;
        hpBar.SetHP((float)pokemon.HP / (float)pokemon.MaxHP);
    }
}
