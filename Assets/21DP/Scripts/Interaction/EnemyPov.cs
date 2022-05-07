using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPov : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    GameObject followToy;
    public Transform toysensor;
    public GameObject[] enemySprites;
    public float back;
    public float front;
    bool canMove = false;
    bool isthereatoy = false;

    public void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = enemyManager._player;
        transform.LookAt(Camera.main.transform);
        StartCoroutine(EnableMovement());
    }
    void Update()
    {
        back = Vector3.Distance(player.position, enemySprites[0].transform.position);
        front = Vector3.Distance(player.position, enemySprites[1].transform.position);
        if (front < back)
        {
            enemySprites[0].gameObject.SetActive(true);
            enemySprites[1].gameObject.SetActive(false);

        }
        else if (back < front)
        {
            enemySprites[0].gameObject.SetActive(false);
            enemySprites[1].gameObject.SetActive(true);
        }

        if (canMove)
        {
            if (isthereatoy == false)
            {
                agent.SetDestination(player.position);
            }
            else if (isthereatoy == true && followToy)
            {
                agent.SetDestination(followToy.transform.position);
            }
        }

    }

    IEnumerator EnableMovement()
    {
        yield return new WaitForSeconds(2f);
        canMove = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Toy")
        {
            isthereatoy = true;
            followToy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Toy")
        {
            Invoke("killToy", 2f);
        }
    }

    void killToy()
    {
        isthereatoy = false;
        if (followToy != null)
        {
            Destroy(followToy.gameObject);
        }
        
    }
}
