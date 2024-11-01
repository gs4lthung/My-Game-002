using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemon/Create a new Pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string pokemonName;
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    // BASE STATS
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [SerializeField] List<LeanrableMove> leanrableMoves;
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
    public int SpDefense
    {
        get { return spDefense; }
        set { spDefense = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public Sprite FrontSprite
    {
        get { return frontSprite; }
        set { frontSprite = value; }
    }
    public Sprite BackSprite
    {
        get { return backSprite; }
        set { backSprite = value; }
    }
    public List<LeanrableMove> LeanrableMoves
    {
        get { return leanrableMoves; }
    }
}
[System.Serializable]
public class LeanrableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;
    public MoveBase Base
    {
        get { return moveBase; }
    }
    public int Level
    {
        get { return level; }
    }
}
public enum PokemonType
{
    None,
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
public class TypeChart
{
    static float[][] chart =
    {
                               //NOR   FIR   WAT   ELE   GRA   ICE   FIG   POI   GRO   FLY   PSY   BUG   ROC   GHO   DRA   DAR   STE   FAI
         /* NOR */  new float[] {1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1/2f, 0f,   1f,   1f,   1/2f, 1f},
         /* FIR */  new float[] {1f,   1/2f, 1/2f, 1f,   2f,   2f,   1f,   1f,   1f,   1f,   1f,   2f,   1/2f, 1f,   1/2f, 1f,   2f,   1f},
         /* WAT */  new float[] {1f,   2f,   1/2f, 1f ,  1/2f, 1f,   1f,   1f,   2f,   1f,   1f,   1f,   2f,   1f,   1/2f, 1f,   1f,   1f},
         /* ELE */  new float[] {1f,   1f,   2f,   1/2f, 1/2f, 1f,   1f,   1f,   0f,   2f,   1f,   1f,   1f,   1f,   1/2f, 1f,   1f,   1f},
         /* GRA */  new float[] {1f,   1/2f, 2f,   1f,   1/2f, 1f,   1f,   1/2f, 2f,   1/2f, 1f,   1/2f, 2f,   1f,   1/2f, 1f,   1/2f, 1f},
         /* ICE */  new float[] {1f,   1/2f, 1/2f, 1f,   2f,   1/2f, 1f,   1f,   2f,   2f,   1f,   1f,   1f,   1f,   2f,   1f,   1/2f, 1f},
         /* FIG */  new float[] {2f,   1f,   1f,   1f,   1f,   2f,   1f,   1/2f, 1f,   1/2f, 1/2f, 1/2f, 2f,   0f,   1f,   2f,   2f,   1/2f},
         /* POI */  new float[] {1f,   1f,   1f,   1f,   2f,   1f,   1f,   1/2f, 1/2f, 1f,   1f,   1f,   1/2f, 1/2f, 1f,   1f,   0f,   2f},
         /* GRO */  new float[] {1f,   2f,   1f,   2f,   1/2f, 1f,   1f,   2f,   1f,   0f,   1f,   1/2f, 2f,   1f,   1f,   1f,   2f,   1f},
         /* FLY */  new float[] {1f,   1f,   1f,   1/2f, 2f,   1f,   2f,   1f,   1f,   1f,   1f,   2f,   1/2f, 1f,   1f,   1f,   1/2f, 1f},
         /* PSY */  new float[] {1f,   1f,   1f,   1f,   1f,   1f,   2f,   2f,   1f,   1f,   1/2f, 1f,   1f,   1f,   1f,   0f,   1/2f, 1f},
         /* BUG */  new float[] {1f,   1/2f, 1f,   1f,   2f,   1f,   1/2f, 1/2f, 1f,   1/2f, 2f,   1f,   1f,   1/2f, 1f,   2f,   1/2f, 1/2f},
         /* ROC */  new float[] {1f,   2f,   1f,   1f,   1f,   2f,   1/2f, 1f,   1/2f, 2f,   1f,   2f,   1f,   1f,   1f,   1f,   1/2f, 1f},
         /* GHO */  new float[] {0f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   2f,   1f,   1f,   2f,   1f,   1/2f, 1f,   1f},
         /* DRA */  new float[] {1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   2f,   1f,   1/2f, 0f},
         /* DAR */  new float[] {1f,   1f,   1f,   1f,   1f,   1f,   1/2f, 1f,   1f,   1f,   2f,   1f,   1f,   2f,   1f,   1/2f, 1f,   1/2f},
         /* STE */  new float[] {1f,   1/2f, 1/2f, 1/2f, 1f,   2f,   1f,   1f,   1f,   1f,   1f,   1f,   2f,   1f,   1f,   1f,   1/2f, 2f},
         /* FAI */  new float[] {1f,   1/2f, 1f,   1f,   1f,   1f,   2f,   1/2f, 1f,   1f,   1f,   1f,   1f,   1f,   2f,   2f,   1/2f, 1f}
    };
    public static float GetEffectiveness(PokemonType attackType, PokemonType defenseType)
    {
        if (attackType == PokemonType.None || defenseType == PokemonType.None)
        {
            return 1;
        }

        int row = (int)attackType - 1;
        int col = (int)defenseType - 1;
        return chart[row][col];
    }
}