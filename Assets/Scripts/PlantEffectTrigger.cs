using UnityEngine;
using System.Collections;

public class PlantEffectTrigger : MonoBehaviour
{
    public GameObject effectPrefab;   
    public float effectDuration = 3f; 

    private bool triggered = false;

    void OnTriggerEnter(Collider other)
    {
      
        if (!triggered && other.CompareTag("Player"))
        {
            triggered = true;
            StartCoroutine(TriggerEffect());
        }
    }

    IEnumerator TriggerEffect()
    {
       
        GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

       
        effect.name = "PlantEffect";

        
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            Color originalColor = rend.material.color;
            float elapsed = 0f;

            while (elapsed < effectDuration)
            {
                float t = Mathf.PingPong(elapsed * 2f, 1f);
                rend.material.color = Color.Lerp(originalColor, Color.yellow, t);
                elapsed += Time.deltaTime;
                yield return null;
            }

            rend.material.color = originalColor;
        }
        else
        {
            
            yield return new WaitForSeconds(effectDuration);
        }

       
        Destroy(effect);
        Destroy(gameObject);
    }
}