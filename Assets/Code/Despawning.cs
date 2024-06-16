using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawning : MonoBehaviour
{
    public float delay = 3;
    public float time = 3;

    Animator anim;
    bool spawned = true;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        StartCoroutine(waiter());
    }

    private IEnumerator waiter()
    {
        yield return new WaitForSeconds(time);
        if (spawned)
        {
            anim.SetTrigger("Despawn");
            spawned = false;
        }
    }
}
