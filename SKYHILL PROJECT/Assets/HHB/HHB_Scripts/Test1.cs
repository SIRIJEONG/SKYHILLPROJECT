using UnityEngine;

public class ObjectTileManager : MonoBehaviour
{
    public GameObject roomPrefabs;
    public GameObject evPrefabs;


    public Vector2Int gridSize = new Vector2Int(5, 5);
    public Vector2 cellSize = new Vector2(1.0f, 1.0f);

    public Vector2 evCellSize = new Vector2(2.8f, 2f);



    private void Start()
    {
        GenerateObjects();
    }

    private void GenerateObjects()
    {

        for (int x = 0; x < gridSize.x; x++)
        {

            for (int y = 0; y < gridSize.y; y++)
            {
                if (x % 2 == 0)
                {

                    float xPos = (x * cellSize.x) - 8.5f;
                    float yPos = (y * cellSize.y) - 210.75f;
                    Vector3 spawnPosition = new Vector3(xPos, yPos, 0);
                    GameObject newObject = Instantiate(roomPrefabs, spawnPosition, Quaternion.identity);
                    newObject.transform.parent = transform; // Optional: Set as child of the tilemap
                }

                else if (x % 2 == 1)
                {
                    float xPos = (x * evCellSize.x);
                    float yPos = (y * evCellSize.y);

                    Vector3 spawnPosition = new Vector3(xPos, yPos, 0);
                    GameObject newObject = Instantiate(evPrefabs, spawnPosition, Quaternion.identity);
                    newObject.transform.parent = transform;
                }
            }
        }
    }
}
