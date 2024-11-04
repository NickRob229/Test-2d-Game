using System.Collections;
using UnityEngine;

public class Array_Code : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Declare the ArrayList
    private ArrayList WeaponList;


    void Start()
    {
        // Initialize the ArrayList
        WeaponList = new ArrayList();

        // Adding some initial items
        WeaponList.Add("Bronze Sword");
        WeaponList.Add("Bronze Staff");
        WeaponList.Add("Holy Blade");

        // Display current items
        DisplayItems();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayItems()
    {
        Debug.Log("Current items in the list:");
        foreach (string item in WeaponList)
        {
            Debug.Log(item);
        }
    }
}
