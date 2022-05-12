using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathSystem : MonoBehaviour
{
    public GameObject[] heartsIcons;
    public GameObject[] toys;
    public Transform spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ManageInvocation(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ManageInvocation(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ManageInvocation(2);
    }

    void ManageInvocation(int index)
    {
        if (heartsIcons[index].activeSelf)
        {
            GameObject instance = Instantiate(toys[index], spawnPoint.position, Quaternion.identity);
            instance.transform.localEulerAngles = transform.eulerAngles;
            heartsIcons[index].SetActive(false);
        }
    }

    public void ReloadToys()
    {
        heartsIcons[0].SetActive(true);
        heartsIcons[1].SetActive(true);
        heartsIcons[2].SetActive(true);
    }
}
