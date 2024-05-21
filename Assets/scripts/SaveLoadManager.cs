using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private Transform playerTransform;

    void Start()
    {
        // Encuentra al jugador al inicio
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        LoadGame();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetFloat("PlayerX", playerTransform.position.x);
        PlayerPrefs.SetFloat("PlayerY", playerTransform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", playerTransform.position.z);
        PlayerPrefs.SetFloat("PlayerRotationX", playerTransform.rotation.eulerAngles.x);
        PlayerPrefs.SetFloat("PlayerRotationY", playerTransform.rotation.eulerAngles.y);
        PlayerPrefs.SetFloat("PlayerRotationZ", playerTransform.rotation.eulerAngles.z);
        PlayerPrefs.Save();
        Debug.Log("Game Saved");
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("PlayerX"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX");
            float y = PlayerPrefs.GetFloat("PlayerY");
            float z = PlayerPrefs.GetFloat("PlayerZ");
            float rotX = PlayerPrefs.GetFloat("PlayerRotationX");
            float rotY = PlayerPrefs.GetFloat("PlayerRotationY");
            float rotZ = PlayerPrefs.GetFloat("PlayerRotationZ");

            playerTransform.position = new Vector3(x, y, z);
            playerTransform.rotation = Quaternion.Euler(rotX, rotY, rotZ);

            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No save data found");
        }
    }
}
