using System.Collections;
using UnityEngine;
public class ChompForce : MonoBehaviour
{
    public int force;
    void Start()
    {
        StartCoroutine(Push(3.5f));
    }
    void Update()
    {

    }

    IEnumerator Push(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().AddForce(force, 0, 0);
        
    }

}
