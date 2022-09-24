using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private Animator anim;
    private bool levelCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && levelCompleted == false)
        {
            levelCompleted = true;
            anim.SetInteger("state", 1);
            Invoke("CompleteLevel", 2f);
        }
    }
    private void FinishWinFlag()
    {
        anim.SetInteger("state", 2);
    }
    private void CompleteLevel()
    {
        //aca iria el siguiente nivel
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
