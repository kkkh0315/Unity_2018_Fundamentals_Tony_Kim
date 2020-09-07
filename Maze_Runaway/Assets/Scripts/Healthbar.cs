using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private float newHP;

    public Slider healthbar;
    private GameObject player;
    private PlayerController playercontroller;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Hero_Low");
        playercontroller = player.gameObject.GetComponent<PlayerController>();
        if (healthbar)
            healthbar.value = playercontroller.CurHP / playercontroller.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        newHP = playercontroller.CurHP / playercontroller.MaxHP;
        if (healthbar)
            healthbar.value = Mathf.MoveTowards(healthbar.value, newHP, Time.deltaTime * 0.5f);
    }
}
