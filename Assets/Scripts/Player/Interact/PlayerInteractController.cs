using UnityEngine;

public class PlayerInteractController : MonoBehaviour
{

    public LayerMask solidObjectsLayer;
    public LayerMask longGrassLayer;

    public float percentEncounterPokemon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool CheckEncounterSolidObjects(Vector3 targetPos)
    {
        Collider2D solidObjectsCheck = Physics2D.OverlapCircle(targetPos, 0.2f, solidObjectsLayer);
        if (solidObjectsCheck != null)
        {
            return false;
        }
        return true;
    }
    public void CheckEncounterLongGrass()
    {
        Collider2D longGrassCheck = Physics2D.OverlapCircle(transform.position, 0.2f, longGrassLayer);
        if (longGrassCheck != null)
        {
            if (UnityEngine.Random.Range(1, 101) <= percentEncounterPokemon)
            {
                Debug.Log("Encountered a wild Pokemon !!!");
            }
        }
    }

}
