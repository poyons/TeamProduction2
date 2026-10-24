using UnityEngine;

public class BackGroundGenerate : MonoBehaviour
{
    //”wŒi‚ÌƒvƒŒƒnƒu
    [SerializeField] GameObject BGPrefabs;
    private int x=5;

    //©“®¶¬‚·‚éŠÖ”
    public void Generate()
    {
        float y = Random.Range(-1, 2);
        Instantiate(BGPrefabs,
            new Vector2(x,y),
            Quaternion.identity
            );
        x += 24;
    }
}

