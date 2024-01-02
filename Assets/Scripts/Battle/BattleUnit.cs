using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class BattleUnit : MonoBehaviour
{
    [SerializeField] PokemonBase _base;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;
    public Pokemon Pokemon { get; set; }

    Image image;
    Vector3 originalPos;
    private void Awake()
    {
        image = GetComponent<Image>();
        originalPos = image.rectTransform.localPosition;
    }
    public void SetUp()
    {
        Pokemon = new Pokemon(_base, level);
        if (isPlayerUnit)
        {
            image.sprite = Pokemon.Base.BackSprite;
        }
        else
        {
            image.sprite = Pokemon.Base.FrontSprite;
        }
        PlayerEnterAnimation();
    }
    public void PlayerEnterAnimation()
    {
        if (isPlayerUnit)
        {
            image.transform.localPosition = new Vector3(-500f, originalPos.y, originalPos.z);
        }
        else
        {
            image.transform.localPosition = new Vector3(500f, originalPos.y, originalPos.z);
        }
        image.transform.DOLocalMoveX(originalPos.x, 1f);
    }
    public void PlayerAttackAnimation()
    {
        var sequence = DOTween.Sequence();
        if (isPlayerUnit)
        {
            sequence.Append(image.transform.DOLocalMoveX(originalPos.x + 50f, 0.25f));
        }
        else
        {
            sequence.Append(image.transform.DOLocalMoveX(originalPos.x - 50f, 0.25f));
        }
        sequence.Append(image.transform.DOLocalMoveX(originalPos.x, 0.25f));
    }
}
