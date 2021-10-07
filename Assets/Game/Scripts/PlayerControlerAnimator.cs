using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlerAnimator : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public static int finalScore;
    public Text winScore;
    public Text gameScore;
    public Animator anim;
    private Rigidbody rb;
    public float rotationSpeed;
    public float speed = 2f;
    protected Joystick joystick;
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        anim.SetFloat("vertical", joystick.Vertical);
        Vector3 movement = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        Vector3 localMovement = transform.TransformDirection(movement);
        rb.AddForce(localMovement);
        if (localMovement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(localMovement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            AudioManager.instance.play("pickUp");
            Score.instace.AddScore();
        }
        PlayerWin();
    }
    void PlayerWin()
    {
        if (Score.score>=200)
        {
            finalScore = Score.score * 2;
            panel.SetActive(true);
            panel2.SetActive(false);
            gameScore.text = Score.score.ToString();
            winScore.text = Score.highscore.ToString();

        }
    }
}
