using UnityEngine;

public class Weapon : MonoBehaviour
{
    private GameObject player;
    private Animator player_anim;
    private EnemyController enemy;

    private void Awake()
    {
        player = GameObject.Find("Hero_Low");
        player_anim = player.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemy = other.gameObject.GetComponent<EnemyController>();
            if (enemy.health > 0)
                enemy.health -= 1;
            else
                enemy.health = 0;   
        }
    }
}
