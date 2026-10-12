using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyScript : MonoBehaviour
{
    public PlayerSO playerData;
    public PlayerScript player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.damagePlayer.IsPressed())
        {
            print("Player has been damaged");
            playerData.health -= 10;
        }
    }
}
