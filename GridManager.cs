using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public GameObject gridCellPrefabs;
    private GameObject[,] gameGrid;

    private int height = 7;
    private int width = 7;
    private float gridSpaceSize = 1.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        

        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreateGrid()
    {
        List<string> birdsList = new List<string>();

        birdsList.Add("Peacock");
        birdsList.Add("sparrow");
        birdsList.Add("crow");
        birdsList.Add("Pigeon");
        birdsList.Add("Peacock");
        birdsList.Add("Peacock");
        birdsList.Add("Peacock");
        birdsList.Add("Peacock");
        birdsList.Add("Peacock");
        birdsList.Add("Peacock");

        gameGrid = new GameObject[height, width];
        

        for(int z = 0; z < height; z++)
        {
            for(int x = 0; x < width; x++)
            {
                gameGrid[x, z] = Instantiate(gridCellPrefabs, new Vector3(x * gridSpaceSize,0, z * gridSpaceSize), Quaternion.identity);
                gameGrid[x, z].GetComponentInChildren<TextMesh>().text = birdsList[Random.Range(0, birdsList.Count)];

            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
