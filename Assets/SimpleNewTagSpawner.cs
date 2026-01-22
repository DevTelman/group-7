using UnityEngine;
using System.Collections;

public class SimpleNewTagSpawner : MonoBehaviour
{
    public GameObject NewTagPrefab;
    public int count = 10;
    public float range = 10f;
    public Vector3 center = Vector3.zero;
    public float delay = 0.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            StartCoroutine(Spawn());

   
    }
    IEnumerator Spawn()
    { 
        for (int i = 0; i < count; i ++)
        {
            Vector3 pos = new Vector3(
             Random.Range(-range, range), 0f, Random.Range(-range, range));
            Instantiate(NewTagPrefab, pos, Quaternion.identity);
            string area = GetArea(pos);
            Debug.Log($"NewTag {i + 1}in area:");
            NewTagLogic logic = GetComponent <NewTagLogic> ();
           
            if (logic !=null)
            {
                logic.center = center;
            }
            yield return new WaitForSeconds(delay);
        }
        
    }
    string GetArea (Vector3 pos)

    {
        if (pos.x < 0 && pos.z > 0)
            return "Ձախ Վերև";
        if (pos.x >= 0 && pos.z > 0)
            return "Աջ Վերև";
        if (pos.x < 0 && pos.z <= 0)
            return "Ձախ Ներքև";
        return "Աջ Ներքև";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
