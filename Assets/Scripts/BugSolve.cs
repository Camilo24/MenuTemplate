using UnityEngine;
using UnityEngine.SceneManagement;

public class BugSolve : MonoBehaviour
{
    public GameObject panelOptions;
    public GameObject panelMain;

    void Update()
    {
        GameObject[] objetos = Resources.FindObjectsOfTypeAll<GameObject>();

        foreach (GameObject objeto in objetos)
        {
            if (objeto.name == "PanelOptions" && !objeto.activeInHierarchy)
            {
                panelOptions = objeto;
                break;
            }
        }

        foreach (GameObject objeto in objetos)
        {
            if (objeto.name == "PanelMain" && !objeto.activeInHierarchy)
            {
                panelMain = objeto;
                break;
            }
        }
    }

    public void ActiveOptions()
    {
        panelOptions.SetActive(true);
    }

    public void ActiveMain()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            panelMain.SetActive(true);
        }
    }
}
