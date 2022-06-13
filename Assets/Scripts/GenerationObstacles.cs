using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationObstacles : MonoBehaviour
{

    public float tempsMax = 1;
    public int taille;
    private float timer = 0, timer1 = 0;
    private int indice;
    public GameObject[] objectToUse;
    public float height;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer1 > 50)
        {
            GameObject nouveauobjectToUse = Instantiate(objectToUse[0]);
            nouveauobjectToUse.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(nouveauobjectToUse, 10);
            timer1 = 0;
            timer = 0;
        }
        else
            //si temms plus grand que maxtime
            if (timer > tempsMax)
            {
                indice = Random.Range(1, taille);
                //Debug.Log(""+taille+indice);
                GameObject nouveauobjectToUse = Instantiate(objectToUse[indice]);
                Destroy(nouveauobjectToUse, 10);
                timer = 0;
            }
        timer1 += Time.deltaTime;
        timer += Time.deltaTime;
    }
}