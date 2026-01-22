using UnityEngine;

public class NewTagLogic : MonoBehaviour
{
    public Vector3 center = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string area = GetArea(transform.position);
        Debug.Log(gameObject.name + " հայտնվել է հատվածում: " + area);

        
    }
    string GetArea(Vector3 pos)
    {
        if (pos.x < center.x && pos.z > center.z) return "Ձախ Վերև";
        if (pos.x >= center.x && pos.z > center.z) return "Աջ Վերև";
        if (pos.x < center.x && pos.z <= center.z) return "Ձախ Ներքև";
        return "Աջ Ներքև";
    }
}


  