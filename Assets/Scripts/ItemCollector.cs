using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//para el text

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text cherriesText;//from Unity
    private int countCherries = 0;

    [SerializeField] private Text pineapplesText;//from Unity
    private int countPineapples = 0;

    [SerializeField] private Text melonsText;//from Unity
    private int countMelons = 0;
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

        if (collision.gameObject.CompareTag("PineappleItem"))
        {
            Destroy(collision.gameObject);
            countPineapples++;
            Debug.Log("pineapples:" + countPineapples);
            pineapplesText.text = "Pineapples: " + countPineapples.ToString();
        }

        if (collision.gameObject.CompareTag("MelonItem"))
        {
            Destroy(collision.gameObject);
            countMelons++;
            Debug.Log("melons:" + countMelons);
            melonsText.text = "Melons: " + countMelons.ToString();
        }
    }
}
