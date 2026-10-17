using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 velocity;
    public PlayerInput input;
    [SerializeField] private float VerticalSpeed = 15f;
    [SerializeField] private float HorizontalSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VerticalSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(velocity* Time.deltaTime);
        velocity = new Vector3(HorizontalSpeed,VerticalSpeed,0);
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            VerticalSpeed = 15f;
        }
        VerticalSpeed += Physics.gravity.y * Time.deltaTime;
        if(VerticalSpeed<-40f)
        {
            VerticalSpeed = -40f;
        }
    }
}
