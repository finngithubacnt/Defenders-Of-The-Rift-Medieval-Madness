using UnityEditor;
using UnityEngine;

public class WaveSystem2D : MonoBehaviour
{
    public float waveNumber = 1;
    public float enemiesToSpawn = 5;
    public float EnemiesAlive = 0;
    public bool waveInProgress = false;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public GameObject EnemyDefault;
    public bool wavesTurnedOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (wavesTurnedOn == true && waveInProgress == false)
        { 
                newwave();
            
        }
       if (EnemiesAlive <= 0 && wavesTurnedOn == true)
        {
            waveInProgress = false;
            waveNumber += 1;
            
        }
    }

    void newwave()
    {
        waveInProgress = true;
        EnemiesAlive = enemiesToSpawn;
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            GameObject projectile = Instantiate(EnemyDefault, spawn1.position, spawn1.rotation &);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        }
    }
}
