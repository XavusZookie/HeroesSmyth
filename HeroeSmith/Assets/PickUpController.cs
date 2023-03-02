using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public sword gunScript;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, gunContainer, fpsCam;

    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;
    public bool canattack = false;
    public float cooldown = 010.0f;


    private void Start()
    {
        player = GameObject.Find("player").transform;
        fpsCam = player;
        gunContainer = GameObject.Find("swordhand").transform;

        //Setup
        if (!equipped)
        {
            //gunScript.enabled = false;
            rb.isKinematic = false;
            //coll.isTrigger = false;
            canattack = false;
        }
        if (equipped)
        {
            //gunScript.enabled = true;
            rb.isKinematic = true;
            //coll.isTrigger = true;
            slotFull = true;
            canattack = true;

        }
    }

    private void Update()
    {
        //Check if player is in range and "E" is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp();

        //Drop if equipped and "Q" is pressed
        if (equipped && Input.GetKeyDown(KeyCode.Q)) Drop();

        if(Input.GetMouseButtonDown(0))
        {
            if(canattack)
            {
                attack();
            }
        }
    }

    public void attack()
    {
        canattack = false;
        Animator anim = gunContainer.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(resetattackcooldown());
    }

    IEnumerator resetattackcooldown()
    {
        yield return new WaitForSeconds(cooldown);
        canattack = true;

    }

    private void PickUp()
    {
        equipped = true;
        slotFull = true;
        canattack = true;

        //Make weapon a child of the camera and move it to default position


        transform.localRotation = fpsCam.rotation;

        transform.Rotate(new Vector3(0, 270, 0));
        if(this.GetComponent<sword>().mold == "Rapier")
        {
            transform.Rotate(new Vector3(0, 180, 0));

        }
        transform.SetParent(gunContainer);
        transform.localPosition = Vector3.zero;


        //transform.localScale = Vector3.one;

        //Make Rigidbody kinematic and BoxCollider a trigger
        rb.isKinematic = true;
       // coll.isTrigger = true;

        //Enable script
        //gunScript.enabled = true;
    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;
        canattack = false;

        //Set parent to null
        transform.SetParent(null);

        //Make Rigidbody not kinematic and BoxCollider normal
        rb.isKinematic = false;
       // coll.isTrigger = false;

        //Gun carries momentum of player
        rb.velocity = new Vector3(player.GetComponent<Rigidbody>().velocity.x, 0, player.GetComponent<Rigidbody>().velocity.z);

        //AddForce
        rb.AddForce(fpsCam.forward * dropForwardForce, ForceMode.Impulse);
        rb.AddForce(fpsCam.up * dropUpwardForce, ForceMode.Impulse);
        //Add random rotation
        float random = Random.Range(-1f, 1f);
        rb.AddTorque(new Vector3(random, random, random) * 10);

        //Disable script
        //gunScript.enabled = false;
    }
}
