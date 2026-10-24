using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 velocity;
    public PlayerInput input;
    private float VerticalSpeed ;
    [SerializeField] private float HorizontalSpeed = 5.0f;
    public int jumpPower=5;

    public Vector2 playerPosition;
    public Vector2 generatePlayerPosition;
    [SerializeField] PipeGenerate _pipeGenerate;
    [SerializeField] BackGroundGenerate backGroundGenerate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VerticalSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = transform.position;
        transform.Translate(velocity* Time.deltaTime);
        velocity = new Vector3(HorizontalSpeed,VerticalSpeed,0);
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            VerticalSpeed = jumpPower;
        }
        VerticalSpeed += Physics.gravity.y * Time.deltaTime;
        if(VerticalSpeed<-6f)
        {
            VerticalSpeed = -6f;
        }
        pipeGenerate();
    }

    //“yŠÇ‚Ì¶¬Ý’è
    public void pipeGenerate()
    {
        if (playerPosition.x >= generatePlayerPosition.x)
        {
            generatePlayerPosition.x += 5;
            _pipeGenerate.Generate();
        }
    }
}
