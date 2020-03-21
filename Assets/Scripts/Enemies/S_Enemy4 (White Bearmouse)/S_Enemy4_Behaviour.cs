﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Enemy4_Behaviour : MonoBehaviour
{
    private Transform playerTarget;
    private Animator anim;


    public float aggroMaxRange = 7;
    public float aggroMinRange = 0;
    public float countingTime = 0;
    public float speed = 1.0f;
    public float direction = 1.0f;
    public bool moveVert = false;
    public bool isMoving = true;
    public bool touchingPlayer = false;


    //Diff for each NPC
    public Vector3 startPos = new Vector3(0, 0, 0);
    public bool dest0 = false;
    public bool dest1 = true;
    public bool dest2 = false;
    public bool dest3 = false;
    public bool dest4 = false;
    public bool dest5 = false;

    public int nextDirection;
    public int whenNext;

    public bool once = true;
    public bool once2 = true;

    public float newPlace;

    void Start()
    {
        startPos = this.gameObject.transform.position;
        anim = GetComponent<Animator>();
        playerTarget = FindObjectOfType<PlayerChar>().transform;
        anim.SetBool("moveVert", false);
        anim.SetBool("isMoving", true);
    }

    void Update()
    {

        if (touchingPlayer == false)
        {

            //Any movement stuff
            countingTime += Time.deltaTime;
            if (dest0 == true)
            {
                anim.SetBool("isMoving", true);
                anim.SetBool("moveVert", false);
                direction = -1.0f;

                if (once2 == true)
                {
                    newPlace = transform.position.x - 1;
                    once2 = false;
                }

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(newPlace, transform.position.y, 0), 0.03f);

                if (transform.position.x == newPlace)
                {
                    if (once == true)
                    {
                        countingTime = 0;
                        if (startPos.x + transform.position.x == 0)
                        {
                            nextDirection = Random.Range(0, 2);
                        }
                        else
                        {
                            nextDirection = Random.Range(1, 4);
                        }

                        whenNext = Random.Range(3, 8);
                        once = false;
                    }

                    anim.SetBool("isMoving", false);

                    if (countingTime > whenNext)
                    {
                        dest0 = false;
                        switch (nextDirection)
                        {
                            case 0:
                                dest2 = true;
                                break;
                            case 1:
                                dest1 = true;
                                break;
                            case 2:
                                dest4 = true;
                                break;
                            case 3:
                                dest0 = true;
                                break;
                        }
                        once2 = true;
                        once = true;
                    }
                }
            }
            else if (dest1 == true)
            {
                anim.SetBool("isMoving", true);
                anim.SetBool("moveVert", false);
                direction = 1.0f;

                if (once2 == true)
                {
                    newPlace = transform.position.x + 1;
                    once2 = false;
                }

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(newPlace, transform.position.y, 0), 0.03f);

                if (transform.position.x == newPlace)
                {
                    if (once == true)
                    {
                        countingTime = 0;
                        if (startPos.x + transform.position.x == 2)
                        {
                            nextDirection = Random.Range(0, 2);
                        }
                        else
                        {
                            nextDirection = Random.Range(1, 4);
                        }
                        whenNext = Random.Range(3, 8);
                        once = false;
                    }

                    anim.SetBool("isMoving", false);
                    if (countingTime > whenNext)
                    {
                        dest1 = false;
                        switch (nextDirection)
                        {
                            case 0:
                                dest3 = true;
                                break;
                            case 1:
                                dest0 = true;
                                break;
                            case 2:
                                dest4 = true;
                                break;
                            case 3:
                                dest1 = true;
                                break;
                        }
                        once2 = true;
                        once = true;
                    }
                }
            }
            else if (dest2 == true)
            {
                anim.SetBool("isMoving", true);
                anim.SetBool("moveVert", false);
                direction = 1.0f;
                if (once2 == true)
                {
                    newPlace = transform.position.x + 2;
                    once2 = false;
                }

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(newPlace, transform.position.y, 0), 0.03f);

                if (transform.position.x == newPlace)
                {
                    if (once == true)
                    {
                        countingTime = 0;
                        nextDirection = Random.Range(0, 2);
                        whenNext = Random.Range(3, 8);
                        once = false;
                    }


                    // nextDirection = Random.Range(0, 2);


                    anim.SetBool("isMoving", false);
                    if (countingTime > whenNext)
                    {
                        switch (nextDirection)
                        {
                            case 0:
                                dest0 = true;
                                break;
                            case 1:
                                dest3 = true;
                                break;
                        }
                        once2 = true;
                        once = true;
                        dest2 = false;
                    }
                }
            }
            else if (dest3 == true)
            {
                anim.SetBool("isMoving", true);
                anim.SetBool("moveVert", false);
                direction = -1.0f;

                if (once2 == true)
                {
                    newPlace = transform.position.x - 2;
                    once2 = false;
                }

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(newPlace, transform.position.y, 0), 0.03f);

                if (transform.position.x == newPlace)
                {
                    if (once == true)
                    {
                        countingTime = 0;
                        nextDirection = Random.Range(0, 2);
                        whenNext = Random.Range(3, 8);
                        once = false;
                    }

                    anim.SetBool("isMoving", false);

                    if (countingTime > whenNext)
                    {
                        switch (nextDirection)
                        {
                            case 0:
                                dest1 = true;
                                break;
                            case 1:
                                dest2 = true;
                                break;
                        }
                        once2 = true;
                        once = true;
                        dest3 = false;
                    }
                }
            }
            else if (dest4 == true)
            {
                anim.SetBool("isMoving", true);
                anim.SetBool("moveVert", true);
                direction = -1.0f;

                if (once2 == true)
                {
                    newPlace = transform.position.y - 1;
                    once2 = false;
                }

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, newPlace, 0), 0.03f);

                if (transform.position.y == newPlace)
                {
                    if (once == true)
                    {
                        countingTime = 0;
                        whenNext = Random.Range(3, 8);
                        once = false;
                    }

                    anim.SetBool("isMoving", false);

                    if (countingTime > whenNext)
                    {
                        dest5 = true;

                        once2 = true;
                        once = true;
                        dest4 = false;
                    }
                }
            }
            else if (dest5 == true)
            {
                anim.SetBool("isMoving", true);
                anim.SetBool("moveVert", true);
                direction = 1.0f;

                if (once2 == true)
                {
                    newPlace = transform.position.y + 1;
                    once2 = false;
                }

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, newPlace, 0), 0.03f);

                if (transform.position.y == newPlace)
                {
                    if (once == true)
                    {
                        countingTime = 0;
                        nextDirection = Random.Range(0, 2);
                        whenNext = Random.Range(3, 8);
                        once = false;
                    }

                    anim.SetBool("isMoving", false);

                    if (countingTime > whenNext)
                    {
                        switch (nextDirection)
                        {
                            case 0:
                                dest0 = true;
                                break;
                            case 1:
                                dest1 = true;
                                break;
                        }

                        once2 = true;
                        once = true;
                        dest5 = false;
                    }
                }
            }

            anim.SetFloat("speed", direction);
        }
        else if (touchingPlayer == true && Input.GetKeyDown(KeyCode.Z))
        {
            //NPCtextbox.SetActive(true);
            //Dialogue.NPCnumber = 1;
        }

        //anim.SetFloat("moveY", (playerTarget.position.y - transform.position.y));

        if (Mathf.Abs(playerTarget.position.y - transform.position.y) > Mathf.Abs(playerTarget.position.x - transform.position.x))
        {
            anim.SetFloat("moveX", 0f);
            anim.SetFloat("moveY", (playerTarget.position.y - transform.position.y));
        }
        else
        {
            anim.SetFloat("moveX", (playerTarget.position.x - transform.position.x));
            anim.SetFloat("moveY", 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            touchingPlayer = true;
            isMoving = false;
            anim.SetBool("isMoving", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        touchingPlayer = false;
        isMoving = false;
        anim.SetBool("isMoving", true);
    }

}
