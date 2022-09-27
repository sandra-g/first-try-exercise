using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHead : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject[] waypoints;
    private float speedDown = 5f;
    private float speedUp = 2f;
    private int currentWaypointIndex = 0;
    private Animator anim;
    private enum MovementState {idle, fallling};//0 1
    private MovementState state;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    private void Update()
    {
        //1rst: check if player is close enough to rock to activate it.
        //2nd: if so, move rock rapidly towards the base.
        //3rd: after getting to the base, now rock has to go up slowly to its idle state
        if((Mathf.Abs(transform.position.x - player.gameObject.transform.position.x) < 1f) && isIdle())//if (Vector2.Distance(player.gameObject.transform.position, transform.position)< 3f && isIdle())
        {
            Debug.Log("debe bajar");
            currentWaypointIndex = 1;
            state = MovementState.fallling;//animacion falling
        }
        if(currentWaypointIndex == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speedDown);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speedUp);
        }
        if (Vector2.Distance(waypoints[1/*waypoint0*/].transform.position, transform.position) < .1f)
        {
            //go back Up
            currentWaypointIndex = 0;
            state = MovementState.idle;//animacion idle
        }
        anim.SetInteger("state", (int) state);
    }

    private bool isIdle()
    {
        return Vector2.Distance(transform.position, waypoints[0/*waypoint*/].transform.position) < .1f;
    }
}
