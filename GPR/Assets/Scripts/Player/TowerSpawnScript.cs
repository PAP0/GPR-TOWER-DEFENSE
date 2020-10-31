using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerSpawnScript : MonoBehaviour
{
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    private bool select1;
    private bool select2;
    private bool select3;


    void Update()
    {
        #region Select Tower Type
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                select1 = true;
                select2 = false;
                select3 = false;
                Debug.Log("Standard Tower Selected");
            }       
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                select1 = false;
                select2 = true;
                select3 = false;
                Debug.Log("Multitarget Tower Selected");

            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                select1 = false;
                select2 = false;
                select3 = true;
                Debug.Log("Sniper Tower Selected");
            }
        #endregion

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 spawnpos = hit.point;
            spawnpos.y = 1.34f;
            #region Spawn Tower
            if (Input.GetKeyDown(KeyCode.Mouse0) == true)
            {
                if (hit.collider)
                {
                    if (hit.collider.tag == "placeable")
                    {
                        if (select1 == true)
                        {
                            Instantiate(tower1, spawnpos, Quaternion.identity);
                            Debug.Log("Placed Standard Tower at " + Input.mousePosition);
                        }

                        if (select2 == true)
                        {
                            Instantiate(tower2, spawnpos, Quaternion.identity);
                            Debug.Log("Placed Multitarget Tower at " + Input.mousePosition);
                        }

                        if (select3 == true)
                        {
                            Instantiate(tower3, spawnpos, Quaternion.identity);
                            Debug.Log("Placed Sniper Tower at " + Input.mousePosition);
                        }
                    }
                }
            }
            #endregion

            #region Delete Tower
            if (Input.GetKeyDown(KeyCode.Mouse1) == true)
            {
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider)
                        {
                            if (hit.collider.tag == "PlayerTower")
                            {
                                Destroy(hit.collider.gameObject);
                                Debug.Log("Destroyed tower at " + Input.mousePosition);
                            }
                        }
                    }
                }
            }
            #endregion
        }
    }
}