using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleHUD enemyHUD;
    // Start is called before the first frame update
    void Start()
    {
        SetUpBattle();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetUpBattle()
    {
        playerUnit.SetUp();
        enemyUnit.SetUp();
        playerHUD.SetData(playerUnit.Pokemon);
        enemyHUD.SetData(enemyUnit.Pokemon);
    }
}
