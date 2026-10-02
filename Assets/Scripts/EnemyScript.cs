using UnityEngine;

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
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.anim.Play("Hurt");
            playerData.health -= 10;

            if (playerData.health > 0)
            {
                player.anim.Play("Death");
                playerData.lives -= 1;
            }
        }
    }
}
