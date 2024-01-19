using UnityEngine;

public class InsertionSortScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _spheres;
    void Start()
    {
        InsertionSort(_spheres);
    }

    void InsertionSort(GameObject[] unsortedSpheres) {
        for (int j = 1; j < unsortedSpheres.Length; ++j) {
            GameObject key = unsortedSpheres[j];
            Vector3 keyPosition = key.transform.localPosition;
            int i = j - 1;
            while (i >= 0 && unsortedSpheres[i].transform.localScale.x > key.transform.localScale.x) {
                unsortedSpheres[i + 1].transform.localPosition = new Vector3(unsortedSpheres[i].transform.localPosition.x, 
                    unsortedSpheres[i + 1].transform.localPosition.y, 
                    unsortedSpheres[i + 1].transform.localPosition.z);
                unsortedSpheres[i + 1] = unsortedSpheres[i];
                i--;
            }
        unsortedSpheres[i + 1].transform.localPosition = new Vector3(keyPosition.x, 
            unsortedSpheres[i + 1].transform.localPosition.y, 
            unsortedSpheres[i + 1].transform.localPosition.z);
        unsortedSpheres[i + 1] = key;
        }
    }
}
