using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//para el text

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text cherriesText;//from Unity
    private int countCherries = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CherryItem"))
        {
            Destroy(collision.gameObject);
            countCherries++;
            Debug.Log("cherries:" + countCherries);
            cherriesText.text = "Cherries: " + countCherries.ToString();
        }
    }
}
