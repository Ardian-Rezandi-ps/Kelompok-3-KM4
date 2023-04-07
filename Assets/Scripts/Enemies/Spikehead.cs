
using UnityEngine;

public class Spikehead : EnemyDamage
{
    [SerializeField] private float range;
    [SerializeField] private float speed;
    [SerializeField] private float checkDelay;
    [SerializeField] private LayerMask playerLayer;
    private float checkTimer;
    private Vector3 destination;
    private Vector3[] directions = new Vector3[4];
    private bool attacking;



    private void OnEnable()
    {
        Stop();
    }



    private void Update()
    {
        //move spikehead to destination oflu if attacking
        if(attacking)
        transform.Translate(destination * Time.deltaTime * speed);
        else
        {
            checkTimer += Time.deltaTime;
            if (checkTimer > checkDelay)
                CheckForPlayer();
        }
    }

    private void CheckForPlayer()
    {
        CalculateDirections();

        //4 
        for (int i = 0; i < directions.Length; i++)
        {
            Debug.DrawRay(transform.position, directions[i], Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, directions[i], range, playerLayer);

            if(hit.collider != null && !attacking)
            {
                attacking = true;
                destination = directions[i];
                checkTimer = 0;
            }
        }
    }

    private void CalculateDirections()
    {
        directions[0] = transform.right * range; //right
        directions[1] = -transform.right * range;  // left direction
        directions[2] = transform.up * range; //up
        directions[3] = -transform.up * range; //down

    }

    private void Stop()
    {
        destination = transform.position; // set destination as current position
        attacking = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        Stop();
            //stop spikehead hit something
    }
}
