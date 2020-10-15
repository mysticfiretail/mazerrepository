using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyholder : MonoBehaviour
{

    private List<key.KeyType> keyList;

    private void Awake()
    {
        keyList = new List<key.KeyType>();
    }

    public void AddKey(key.KeyType keyType)
    {
        Debug.Log("added key: " + keyType);
        keyList.Add(keyType);
    }

    public void RemoveKey(key.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainsKey(key.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        key myKey = collider.GetComponent<key>();

        if (myKey != null)
        {
            key.KeyType keyType = myKey.GetKeyType();
            AddKey(keyType);
            Destroy(myKey.gameObject);
        }

        KeyDoor keyDoor = collider.GetComponent<KeyDoor>();

        if (keyDoor != null)
        {
            Debug.Log("got door name " + keyDoor.name);
            if (keyDoor.name == "DoorGreen" && ContainsKey(key.KeyType.green))
            {
                Debug.Log("opening door " + key.KeyType.green);
                keyDoor.OpenDoor(key.KeyType.green);
            }
            if (keyDoor.name == "DoorRed" && ContainsKey(key.KeyType.red))
            {
                Debug.Log("opening door " + key.KeyType.red);
                keyDoor.OpenDoor(key.KeyType.red);
            }
            if (keyDoor.name == "MainDoor" && ContainsKey(key.KeyType.blue))
            {
                Debug.Log("opening door " + key.KeyType.blue);
                keyDoor.OpenDoor(key.KeyType.blue);
            }
        }
    }

}
