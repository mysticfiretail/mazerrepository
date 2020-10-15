using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{

    [SerializeField] private key.KeyType keyType;

    public key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor(key.KeyType keyType)
    {
      //  gameObject.SetActive(false);
     if (keyType == key.KeyType.red)
        {
            SceneManager.LoadScene(2);
        }
    

      if (keyType == key.KeyType.green)
        {
            SceneManager.LoadScene(3);
        }

        if (keyType == key.KeyType.blue)
        {
            SceneManager.LoadScene(1);
        }
    }

}
