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
    public InputAction damagePlayer;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        moveAction = InputSystem.actions.FindAction("Move");
        damagePlayer = InputSystem.actions.FindAction("Damage");

        speed = 15;
    }

    void Update()
    {
        UIscript.ui.DrawText("Name = " + playerData.name);
        UIscript.ui.DrawText("Player score = " + playerData.score);
        UIscript.ui.DrawText("Player health = " + playerData.health);
        UIscript.ui.DrawText("Player lives = " + playerData.lives);

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