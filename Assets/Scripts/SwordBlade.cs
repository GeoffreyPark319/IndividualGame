using UnityEngine;
using UnityEngine.XR;

public class SwordBlade : MonoBehaviour
{
    public GameObject Blade;

    public void PullTheTrigger()
    {
        if(Blade.activeInHierarchy == false)
        {
            Blade.SetActive(true);
        }
        else
        {
            Blade.SetActive(false);
        }
    }
}
