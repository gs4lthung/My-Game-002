using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create a new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PokemonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;    //is number of times a move can be performed

    public string MoveName
    {
        get { return moveName; }
        set { moveName = value; }
    }
    public PokemonType Type
    {
        get { return type; }
        set { type = value; }
    }
    public int Power
    {
        get { return power; }
        set { power = value; }
    }
    public int Accuracy
    {
        get { return accuracy; }
        set { accuracy = value; }
    }
    public int PP
    {
        get { return pp; }
        set { pp = value; }
    }
}
