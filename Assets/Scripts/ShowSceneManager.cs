using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ShowSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject picePos;
    [SerializeField] private GameObject[] allPices;
    public TMP_Text textPiceName;
    public TMP_Text textPiceInfo;
    private GameObject newChessPice;
    void Start()
    {
        GameObject pice = allPices[GameManager.Instance.SelectedChessPice.GetIndex()]; 
        newChessPice = Instantiate(pice, picePos.transform.position, pice.transform.rotation);
        textPiceName.text = GameManager.Instance.SelectedChessPice.GetName();
        textPiceInfo.text = GameManager.Instance.SelectedChessPice.GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        // Animate the chess pice with rotation
        newChessPice.transform.Rotate(Vector3.up, 10 * 5 * Time.deltaTime);
    }

    public void LoadSelectScene()
    {
        SceneManager.LoadScene(0);
    }
}
