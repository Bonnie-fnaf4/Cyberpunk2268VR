using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class AIManager : MonoBehaviour
{
    public int hp = 100;
    Rigidbody rigidbody;
    NavMeshAgent navMeshAgent;
    Animator animator;

    public GameObject ParticleSystem;

    float timerToShoot = 0;
    public ShootAI shootAI;

    public AIManager[] aimanagersFriends;

    bool isDead = false;

    public WinOrNot winOrNot;
    public bool DeadEnemy = false;

    public GameObject Hill;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        winOrNot = GameObject.FindGameObjectWithTag("WorldManager").GetComponent<WinOrNot>();
    }

    void Update()
    {
        timerToShoot += Time.deltaTime;
        if(timerToShoot >= 2 && animator.GetBool("isChasing") && !isDead)
        {
            shootAI.Shoot();
            timerToShoot = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.tag == "Bullet")
        {
            BulletHit();
        }

        if (collision.other.tag == "Knife")
        {
            KnifeHit();
        }

        if (hp <= 0 && !DeadEnemy) //Смерать ИИ
        {
            winOrNot.EnemyDead();
            DeadEnemy = true;

            PlayerPrefs.SetInt("CountKill", PlayerPrefs.GetInt("CountKill") + 1);

            animator.enabled = false;
            //navMeshAgent.enabled = false;
            Destroy(navMeshAgent);
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            animator.SetBool("isChasing", false);
            animator.SetBool("isAttacking", false);
            isDead = true;

            GameObject hillSpawn;
            hillSpawn = Instantiate(Hill, gameObject.transform);
            //hillSpawn.transform.position = new Vector3(0, 5, 0);
            hillSpawn.transform.parent = null;

            Destroy(ParticleSystem);
            //Destroy(gameObject, 30);
        }
    }

    public void BulletHit()
    {
        hp -= Random.Range(45, 75);
        animator.SetBool("isChasing", true);
        animator.SetBool("isPatrolling", false);
        for (int i = 0; i < aimanagersFriends.Length; i++)
        {
            if (aimanagersFriends[i] != null)
                aimanagersFriends[i].isChasingTrue();
        }
    }

    public void KnifeHit()
    {
        hp -= Random.Range(200, 1000);
        animator.SetBool("isChasing", true);
        animator.SetBool("isPatrolling", false);
        for (int i = 0; i < aimanagersFriends.Length; i++)
        {
            if (aimanagersFriends[i] != null)
                aimanagersFriends[i].isChasingTrue();
        }
    }

    public void isChasingTrue()
    {
        animator.SetBool("isChasing", true);
        animator.SetBool("isPatrolling", false);
    }
}
