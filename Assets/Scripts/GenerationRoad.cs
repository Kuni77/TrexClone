using UnityEngine;

public class GenerationRoad : MonoBehaviour
{
    public GameObject[] objectToUse;
    private GameObject newobjectToUse;
    private int indice;

    void Start()
    {
        int indice = Random.Range(0, 2);
        newobjectToUse = Instantiate(objectToUse[indice]);
        Destroy(newobjectToUse, 10);
    }
    
    // Update is called once per frame
    void Update()
    {      
        if (newobjectToUse.GetComponent<MoveLeft>().GetCollisionChecker())
        {
            newobjectToUse = Instantiate(objectToUse[indice]);
            Destroy(newobjectToUse, 20);
            indice = Random.Range(0, 2);
        }
    }
}
