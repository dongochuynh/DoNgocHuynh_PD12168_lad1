using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(message: "Start");
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(message: "Press Q");
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(message: "Press W");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(message: "Press E");
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(message: "Press R");
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message: "Press A");
            _son.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(message: "Press S");
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message: "Press D");
            _si.Play();
        }

    }
}