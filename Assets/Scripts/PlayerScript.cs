using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public PlayerSO playerData;
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public Animator anim;
    float speed;

    //defining the actions
    public InputAction moveAction;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        moveAction = InputSystem.actions.FindAction("Move");

        speed = 15;
    }

    void Update()
    {
        float x = moveAction.ReadValue<Vector2>().x;

        rb.linearVelocity = moveAction.ReadValue<Vector2>() * speed;

        if(x < 0.1f && x > -0.1f)
        {
            anim.Play("Idle");
        }
        else
        {
            anim.Play("Run");
        }
    }  
}