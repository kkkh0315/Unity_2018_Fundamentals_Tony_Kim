using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Image keyImage;
    private bool obtainable = false;

    private void Update()
    {
        if (obtainable && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            if (keyImage)
                keyImage.gameObject.SetActive(true);
            obtainable = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            obtainable = true;
        }
    }
}
