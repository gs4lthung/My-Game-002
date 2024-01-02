using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] Image healthFill;

    public void SetHP(float hpNormalized)
    {
        healthFill.fillAmount = hpNormalized;
    }

    public IEnumerator SetHPSmooth(float newHP)
    {
        float curHP = healthFill.fillAmount;
        float changeAmt = curHP - newHP;

        while (changeAmt > Mathf.Epsilon)
        {
            curHP -= changeAmt * Time.deltaTime;
            healthFill.fillAmount = curHP;
            yield return null;
        }
        healthFill.fillAmount = newHP;
    }
}