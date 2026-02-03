using UnityEngine;
using System.Collections;

public class ChompPop : MonoBehaviour
{
    public float x;
    public float y;
    public GameObject plant;
    void Start()
    {
        StartCoroutine(Poof(9.3f));
    }
    void Update()
    {

    }

    IEnumerator Poof(float rime)
    {
        yield return new WaitForSeconds(rime);
        plant.SetActive(true);
        StartCoroutine(Jump(3));

    }

    IEnumerator Jump(float k)
    {
        yield return new WaitForSeconds(k);
        plant.GetComponent<Rigidbody>().AddForce(x, y, 0);
    }
}

