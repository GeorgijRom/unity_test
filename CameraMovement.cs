using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float CameraSpeed;
    // Start is called before the first frame update
   /* public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPosition = transform.position;
        float ellapsed = 0.0f;
        while (ellapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.position = new Vector3(x, y, -10);
            ellapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPosition;
    }*/

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, target.transform.position, CameraSpeed);
    }
}
