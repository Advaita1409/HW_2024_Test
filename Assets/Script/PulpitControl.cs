using UnityEngine;
using System.Collections;

public class PulpitController : MonoBehaviour
{
    private float lifeTime;

    public void SetLifeTime(float time)
    {
        lifeTime = time;
        StartCoroutine(DestroyAfterLifetime());
    }

    IEnumerator DestroyAfterLifetime()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
