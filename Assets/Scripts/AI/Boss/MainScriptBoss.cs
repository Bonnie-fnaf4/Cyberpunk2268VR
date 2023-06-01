using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScriptBoss : MonoBehaviour
{
    public Transform player;

    public ShootAI shootAI1, shootAI2, shootAI3, shootAI4, shootAI5;

    public Animator animator;

    public Text hpText;

    public float hp = 5000;

    public Rigidbody rigidbody;

    public GameObject ParticleSystem;

    public float Timer = 0;

    public PlayerManager playerManager;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rigidbody = GetComponent<Rigidbody>();
        //hp = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(hp <= 0)) animator.transform.LookAt(player);
        Timer += Time.deltaTime;

        hpText.text = "" + hp;

        if(hp <= 0)
        {
            rigidbody.useGravity = true;
            rigidbody.isKinematic = false;
            Destroy(ParticleSystem);
            Destroy(animator);
            hpText.enabled = false;
            playerManager.pauseAndWinAndLose.WinVoid();
            playerManager.pauseAndWinAndLose.win = true;
        }

        if(Timer > 2 && !(hp <= 0))
        {
            shootAI1.Shoot();
            shootAI2.Shoot();
            shootAI3.Shoot();
            shootAI4.Shoot();
            shootAI5.Shoot();
            Timer = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.tag == "Bullet")
        {
            hp -= Random.RandomRange(10, 25);
        }
        if (collision.other.tag == "Knife")
        {
            hp -= Random.RandomRange(200, 450);
        }
    }
}
