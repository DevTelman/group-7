using UnityEngine;

public class BarrierCheck : MonoBehaviour
{
    public GameObject animal1;
    public GameObject animal2;

    public bool CanPass()
    {
        if (animal1 == null && animal2 == null)
        {
            return true;
        }

        return false;
    }
}