﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpObject : MonoBehaviour
{
    public GameObject Object;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyUp(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveBox") == false && Object.tag == "Box")
        {
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveBox", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
        }
        if (Input.GetKeyUp(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveH") == false && Object.tag == "Hummer")
        {
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveH", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
        }
        if (Input.GetKeyUp(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveBH") == false && Object.tag == "BigHummer")
        {
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveBH", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
        }
        if (Input.GetKeyUp(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveTape") == false && Object.tag == "Tape")
        {
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveTape", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
        }
    }
}
