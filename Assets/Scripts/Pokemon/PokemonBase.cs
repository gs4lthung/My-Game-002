using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemon/Create a new Pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string pokemonName;

    [TextArea]
    [SerializeField] string description;

    public string PokemonName
    {
        get { return pokemonName; }
        set { pokemonName = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;
    public PokemonType Type1
    {
        get { return type1; }
        set { type1 = value; }
    }
    public PokemonType Type2
    {
        get { return type2; }
        set { type2 = value; }
    }

    // BASE STATS
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public int MaxHP
    {
        get { return maxHP; }
        set { maxHP = value; }
    }
    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }
    public int SpAttack
    {
        get { return spAttack; }
        set { spAttack = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

}

public enum PokemonType
{
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
    Dark,
    Steel,
    Fairy
}
