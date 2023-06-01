using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHellicopter : MonoBehaviour
{
    public Animator animator;

    public ParticleSystem[] FireHelicopter;

    public Transform Player;

    [SerializeField] GameObject Fire;

    public float Timer = 0, TimerTrigger = 6, TimerAction = 3, CountToFire = 3;

    public int Moveint = 1, Actionint, HeartInt = 100000;

    public bool isMove = true, isAction = false, playerInBox = false, dead = false;

    public Rigidbody rigidbody;

    public PlayerManager playerManager;

    public BoxCollider boxCollider;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet") 
        {
            HeartInt -= Random.RandomRange(35, 85);
        }

        if (collision.gameObject.tag == "Knife")
        {
            HeartInt -= Random.RandomRange(3500, 8500);
        }

        if(HeartInt <= 0) dead = true;
    }

    private void Update()
    {
        Timer += Time.deltaTime;

        if (!playerInBox) return;

        boxCollider.enabled = true;

        if (dead)
        {
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            playerInBox = false;
            playerManager.pauseAndWinAndLose.WinVoid();
            Destroy(animator);
            Destroy(gameObject, 5);
            return;
        }

        if(Timer >= TimerTrigger && isMove)
        {
            Move(Moveint);
            Moveint++;
            if (Moveint > 3) Moveint = 1;

            isMove = false;
            isAction = true;
            Timer = 0;
        }
        else
        {
            if (Timer >= TimerAction && isAction)
            {
                FireVoid(10);
                Actionint++;
                if (Actionint > 3)
                {
                    Actionint = 0;
                    isMove = true;
                    isAction = false;
                }

                Timer = 0;
            }
        }
    }

    void Move(int id)
    {
        animator.SetTrigger("Move" + id);
    }

    void FireVoid(int count)
    {
        for(int i = 0; i < FireHelicopter.Length; i++)
        {
            FireHelicopter[i].Play(true);
        }

        GameObject NewFire2 = Instantiate(Fire, Player);
        NewFire2.transform.localPosition = new Vector3(0, -1.5f, 0);
        NewFire2.transform.SetParent(null);
        Destroy(NewFire2, 2);

        for (int i = 0; i < count; i++) 
        {
            GameObject NewFire = Instantiate(Fire, Player);
            NewFire.transform.localPosition = new Vector3(Random.RandomRange(-10, 10), -1.5f, Random.RandomRange(-10, 10));
            NewFire.transform.SetParent(null);
            Destroy(NewFire, 2);
        }
    }
}
