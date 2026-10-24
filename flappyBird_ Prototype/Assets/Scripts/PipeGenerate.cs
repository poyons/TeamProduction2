using UnityEngine;
using UnityEngine.InputSystem;

public class PipeGenerate : MonoBehaviour
{
    //“yŠÇ‚ÌƒvƒŒƒnƒu
    [SerializeField] GameObject pipePrefabs;
    private int x=5;

    //©“®¶¬‚·‚éŠÖ”
    public void Generate()
    {
        float y = Random.Range(-1, 2);
        Instantiate(pipePrefabs,
            new Vector2(x,y),
            Quaternion.identity
            );
        x += 5;
    }
}
