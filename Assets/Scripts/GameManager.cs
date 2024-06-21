using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Script en singleton que persiste entre escenas

    #region Variables

    public static GameManager Instance;

    [Header("Jugador")]
    [SerializeField] private GameObject player;
    [SerializeField] private float player_VelMove = 3;
    [SerializeField] private float player_runMulti = 2;

    [Header("ControlesPC")]
    [SerializeField] private KeyCode Avanzar;

    #endregion


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


}
