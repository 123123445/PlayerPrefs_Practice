using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsTest : MonoBehaviour
{
    public InputField name;
    public InputField age;

    public void save()
    {
        PlayerPrefs.SetString("Name", name.text);
        PlayerPrefs.SetInt("Age", int.Parse(age.text));
    }

    public void Load()
    {
        {
            if (PlayerPrefs.HasKey("Name"))
            {
                name.text = PlayerPrefs.GetString("Name");
                age.text = PlayerPrefs.GetInt("Age").ToString();
            }
        }
    }
}
