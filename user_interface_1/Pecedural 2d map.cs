using UnityEngine;

public class ProceduralMapGenerator : MonoBehaviour
{
    public GameObject[] terrainPrefabs; // 0 = Water, 1 = Grass, 2 = Mountain
    public int width = 100;
    public int height = 100;
    public float scale = 20f;
    public float mountainThreshold = 0.7f;
    public float waterThreshold = 0.3f;
    public float grassThresholdMin = 0.3f;
    public float grassThresholdMax = 0.6f;

    public GameObject player;
    public Transform mapParent; // Assign an empty GameObject in the scene
    private Vector3 playerPosition;
    private Vector3 mapOffset;

    void Start()
    {
        mapOffset = player.transform.position;
        GenerateMap();
        PlacePlayer();
    }

    void GenerateMap()
    {
        // Clear previous map if any
        if (mapParent != null)
        {
            foreach (Transform child in mapParent)
            {
                Destroy(child.gameObject);
            }
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float worldX = x + mapOffset.x;
                float worldY = y + mapOffset.y;

                string terrainType = GetTerrainType(worldX, worldY);
                GameObject tilePrefab = null;

                switch (terrainType)
                {
                    case "Water":
                        tilePrefab = terrainPrefabs[0];
                        break;
                    case "Grass":
                        tilePrefab = terrainPrefabs[1];
                        break;
                    case "Mountain":
                        tilePrefab = terrainPrefabs[2];
                        break;
                }

                if (tilePrefab != null)
                {
                    Vector3 position = new Vector3(worldX, worldY, 0);
                    Instantiate(tilePrefab, position, Quaternion.identity, mapParent);
                }
            }
        }
    }

    void PlacePlayer()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float worldX = x + mapOffset.x;
                float worldY = y + mapOffset.y;

                if (GetTerrainType(worldX, worldY) == "Grass")
                {
                    playerPosition = new Vector3(worldX, worldY, -1);
                    player.transform.position = playerPosition;
                    return;
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) MovePlayer(Vector3.up);
        if (Input.GetKeyDown(KeyCode.DownArrow)) MovePlayer(Vector3.down);
        if (Input.GetKeyDown(KeyCode.LeftArrow)) MovePlayer(Vector3.left);
        if (Input.GetKeyDown(KeyCode.RightArrow)) MovePlayer(Vector3.right);
    }

    void MovePlayer(Vector3 direction)
    {
        Vector3 newPosition = playerPosition + direction;
        float newX = newPosition.x;
        float newY = newPosition.y;

        // Check map bounds
        if (newX >= mapOffset.x && newX < mapOffset.x + width &&
            newY >= mapOffset.y && newY < mapOffset.y + height)
        {
            // Only move on grass tiles
            if (GetTerrainType(newX, newY) == "Grass")
            {
                playerPosition = newPosition;
                player.transform.position = playerPosition;
            }
        }
    }

    string GetTerrainType(float x, float y)
    {
        float perlinValue = Mathf.PerlinNoise(x / scale, y / scale);
        if (perlinValue < waterThreshold)
            return "Water";
        if (perlinValue >= grassThresholdMin && perlinValue <= grassThresholdMax)
            return "Grass";
        if (perlinValue >= mountainThreshold)
            return "Mountain";
        return "None";
    }
}
