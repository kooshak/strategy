using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecourceControl : MonoBehaviour
{
    public Text recourceText;
    public int money;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateRecources();
    }
    private void updateRecources()
    {
        recourceText.text = "Δενόγθ: " + money;
    }
}
