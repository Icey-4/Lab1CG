using System.Collections;
using UnityEngine;

public class FishControl : MonoBehaviour
{
    public Material mat;
    public float speed = 10.0f;
    private float translation;
    private float straffe;
    Vector3 turn;

    void Start()
    {
        turn = new Vector3(0, -180,0);
        StartCoroutine(Shock(4));
        StartCoroutine(K(6.5f));
        mat.SetInt("_IsShock", 0);
    }

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);
    }

    IEnumerator Shock(float T)
    {
        yield return new WaitForSeconds(T);
        mat.SetInt("_IsShock", 1);
    }

    IEnumerator K(float T)
    {
        yield return new WaitForSeconds(T);
        transform.Rotate(turn);
    }
}
