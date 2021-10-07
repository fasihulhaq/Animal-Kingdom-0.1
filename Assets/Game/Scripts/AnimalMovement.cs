﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalMovement : MonoBehaviour
{

    public RandomGenerateAnimalPosition position;
    public float speed;

    private Rigidbody rb;

    public Text scoreView;

    private int score;

    private string showScore;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            score += 20;
            showScore = score.ToString();
            other.gameObject.SetActive(false);
            scoreView.text = showScore;
        }
    }
}
