using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{

    public float tempsMax = 1;
    public int taille;
    private float timer = 0;
    private int indice;
    public GameObject[] objectToUse;
    public float height;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //si temms plus grand que maxtime
        if (timer > tempsMax)
        {
            indice = Random.Range(0, taille);
            //Debug.Log(""+taille+indice);
            GameObject nouveauobjectToUse = Instantiate(objectToUse[indice]);
            nouveauobjectToUse.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(nouveauobjectToUse, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
