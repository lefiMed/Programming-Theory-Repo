using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public ChessPice SelectedChessPice;


    // Update is called once per frame

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                SelectedChessPice = hit.transform.gameObject.GetComponent<ChessPice>();
                Debug.Log(hit.transform.name + " clicked");
                if (SelectedChessPice != null) { SceneManager.LoadScene(1); }
                
            }

        }
    }


    
}
