using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{

    public string swordname;
    public string mold;
    public int chosenmold;

    public string affinity;
    public string quality;

    public int level;
    public int durability;
    public int affinity_tier;

    public float range;
    public float speed;
    public float weight;
    public int total = 101;

    public float attack_power;
    public float attack_speed;
    public float affinity_power;

    bool finished;

    
    public GameObject Scimitar;
    public GameObject Rapier;
    public GameObject SuperKatana;
    public GameObject Longsword;
    public GameObject UltraGreatsword;
    public GameObject Shortsword;
    public GameObject Sabre;
    public GameObject swordmodel;



    // Start is called before the first frame update
    void Start()
    {
        //randomize();
    }

    // Update is called once per frame
    public void randomize()
    {
        randomize_name();
        randomize_mold();
        randomize_affinity();
        randomize_quality();
        randomize_level();
        calculate_durability();
        randomize_affinity_tier();
        randomize_base_stats();
        calculate_attack_power();
        calculate_attack_speed();
        calculate_affinity_power();


    }

    public void choosesword()
    {
        randomize_name();
        choose_mold();
        randomize_affinity();
        randomize_quality();
        randomize_level();
        calculate_durability();
        randomize_affinity_tier();
        randomize_base_stats();
        calculate_attack_power();
        calculate_attack_speed();
        calculate_affinity_power();


    }

    void randomize_name()
    {
        string temp = "abcdefghijklmnopqrstuvwxyz";
        int tempnum;
        for (int i = 0;i < Random.Range(4,11); i++)
        {
            tempnum = Random.Range(0, 26);

            swordname = swordname + temp.Substring(tempnum, 1);
        }
    }

    public void choose_mold()
    {


        int Rmold = chosenmold;
        //GameObject swordmodel;


        switch (Rmold)
        {
            case 0:              //Scimitar
                mold = "Scimitar";
                swordmodel = Instantiate(Scimitar, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 1:              //Rapier
                mold = "Rapier";

                swordmodel = Instantiate(Rapier, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 2:              //Super Katana
                mold = "Super Katana";

                swordmodel = Instantiate(SuperKatana, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 3:              //Longsword
                mold = "Longsword";

                swordmodel = Instantiate(Longsword, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 4:              //Ultra Greatsword
                mold = "Ultra Greatsword";

                swordmodel = Instantiate(UltraGreatsword, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 5:              //Shortsword
                mold = "Shortsword";

                swordmodel = Instantiate(Shortsword, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 6:              //Knights Sword now Sabre
                mold = "Sabre";

                swordmodel = Instantiate(Sabre, this.transform);

                swordmodel.transform.parent = this.transform;
                break;

        }
    }

    void randomize_mold()
    {
        int Rmold = Random.Range(0, 7);
        GameObject swordmodel;
        switch (Rmold)
        {
            case 0:              //Scimitar
                mold = "Scimitar";
                swordmodel = Instantiate(Scimitar, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 1:              //Rapier
                mold = "Rapier";
               
                swordmodel = Instantiate(Rapier, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 2:              //Super Katana
                mold = "Super Katana";
                
                swordmodel = Instantiate(SuperKatana, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 3:              //Longsword
                mold = "Longsword";
                
                swordmodel = Instantiate(Longsword, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 4:              //Ultra Greatsword
                mold = "Ultra Greatsword";
                
                swordmodel = Instantiate(UltraGreatsword, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 5:              //Shortsword
                mold = "Shortsword";
                
                swordmodel = Instantiate(Shortsword, this.transform);

                swordmodel.transform.parent = this.transform;
                break;
            case 6:              //Knights Sword now Sabre
                mold = "Sabre";
                
                swordmodel = Instantiate(Sabre, this.transform);

                swordmodel.transform.parent = this.transform;
                break;

        }
    }

    void randomize_affinity()
    {
        int Raffinity = Random.Range(0, 7);

        switch (Raffinity)
        {
            case 0:              //heat
                affinity = "Heat";
                break;
            case 1:              //cold
                affinity = "Cold";
                break;
            case 2:              //electric 
                affinity = "Electric";
                break;
            case 3:              //poison
                affinity = "Poison";
                break;
            case 4:              //divine
                affinity = "Divine";
                break;
            case 5:              //curse
                affinity = "Curse";
                break;
            case 6:              //nothing
                affinity = "None";
                break;

        }
    }

    void randomize_quality()
    {
        int Rquality = Random.Range(0, 5);

        switch (Rquality)
        {
            case 0:              //heat
                quality = "Novice";
                break;
            case 1:              //cold
                quality = "Apprentice";
                break;
            case 2:              //electric 
                quality = "High";
                break;
            case 3:              //poison
                quality = "Pristine";
                break;
            case 4:              //divine
                quality = "Master";
                if (Random.Range(0, 100) == 0)
                {
                    quality = "Legendary";
                }
                break;
        }
    }

    void randomize_level()
    {
        int Rlevel = Random.Range(1, 51);

        level = Rlevel;
    }

    void calculate_durability()
    {

    }

    void randomize_affinity_tier()
    {
        int Raffinitytier = Random.Range(1, 7);

        affinity_tier = Raffinitytier;

        if (affinity == "None")
        {
            affinity_tier = 0;
        }
    }

    void randomize_base_stats()
    {
        int Rspeed;
        int Rrange;
        int Rweight;
        int Rtotal = 3;
        int Rorder = Random.Range(0, Rtotal);

        switch (Rorder)//first
        {
            case 0:              //range
                Rorder = Random.Range(0, Rtotal - 1);

                Rrange = Random.Range(0, total);

                range = Rrange;

                total = total - Rrange;

                switch (Rorder)
                {
                    case 0:              //speed
                        Rspeed = Random.Range(0, total);

                        speed = Rspeed;

                        total = total - Rspeed;


                        Rweight = Random.Range(0, total);

                        weight = Rweight;

                        total = total - Rweight;
                        break;
                    case 1:              //weight
                        Rweight = Random.Range(0, total);

                        weight = Rweight;

                        total = total - Rweight;


                        Rspeed = Random.Range(0, total);

                        speed = Rspeed;

                        total = total - Rspeed;
                        break;
                }

                break;
            case 1:              //speed
                Rorder = Random.Range(0, Rtotal - 1);
                Rspeed = Random.Range(0, total);

                speed = Rspeed;

                total = total - Rspeed;
                switch (Rorder)
                {
                    case 0:              //speed
                        Rrange = Random.Range(0, total);

                        range = Rrange;

                        total = total - Rrange;


                        Rweight = Random.Range(0, total);

                        weight = Rweight;

                        total = total - Rweight;
                        break;
                    case 1:              //weight
                        Rweight = Random.Range(0, total);

                        weight = Rweight;

                        total = total - Rweight;


                        Rrange = Random.Range(0, total);

                        speed = Rrange;

                        total = total - Rrange;
                        break;
                }
                break;
            case 2:              //weight 
                Rorder = Random.Range(0, Rtotal - 1);

                Rweight = Random.Range(0, total);

                weight = Rweight;

                total = total - Rweight;

                switch (Rorder)
                {
                    case 0:              //speed
                        Rspeed = Random.Range(0, total);

                        speed = Rspeed;

                        total = total - Rspeed;


                        Rrange = Random.Range(0, total);

                        range = Rrange;

                        total = total - Rrange;
                        break;
                    case 1:              //weight
                        Rrange = Random.Range(0, total);

                        range = Rrange;

                        total = total - Rrange;


                        Rspeed = Random.Range(0, total);

                        speed = Rspeed;

                        total = total - Rspeed;
                        break;
                }
                break;

        }//end first

        this.transform.localScale = new Vector3(this.transform.localScale.x * (.3f + weight / 100), this.transform.localScale.y *(.3f + range/100), this.transform.localScale.z * (.3f + weight / 100));

    }

    void calculate_attack_power()
    {
        attack_power = weight * level;
    }

    void calculate_attack_speed()
    {
        attack_speed = speed * level;

    }

    void calculate_affinity_power()
    {
        if (affinity == "None")
        {
            affinity_power = 0;
        }
        else
        {
            affinity_power = attack_power * .5f;
            attack_power = attack_power * .5f;

        }


    }

}