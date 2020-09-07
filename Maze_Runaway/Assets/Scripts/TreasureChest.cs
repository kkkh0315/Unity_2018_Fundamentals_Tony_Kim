using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    private Animator anim;
    private bool open;
    private bool close;
    private bool no_more_keys;

    public Rigidbody keyPrefab;
    public Transform spawner;

    // Start is called before the first frame update
    void Start()
    {
        no_more_keys = false;
        open = false;
        close = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!no_more_keys && open && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Openable", true);
            anim.SetBool("Closeable", false);
            StartCoroutine(SpawnKey());
            no_more_keys = true;
        }
        if (close)
        {
            anim.SetBool("Closeable", true);
            anim.SetBool("Openable", false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            close = false;
            open = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            open = false;
            close = true;
        }
    }

    IEnumerator SpawnKey()
    {
        yield return new WaitForSeconds(2f);
        Rigidbody keyInstance;
        keyInstance = Instantiate(keyPrefab, spawner.position, spawner.rotation) as Rigidbody;
        keyInstance.AddForce(spawner.forward * 200);
    }
}
