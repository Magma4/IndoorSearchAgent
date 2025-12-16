using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Manages all graph nodes in the scene and provides utilities for pathfinding.
/// </summary>
public class GraphManager : MonoBehaviour
{
    [Header("Graph Settings")]
    [Tooltip("All graph nodes in the scene")]
    public List<GraphNode> allNodes = new List<GraphNode>();

    [Tooltip("Auto-find all GraphNode components in scene on start")]
    public bool autoFindNodes = true;

    void Start()
    {
        if (autoFindNodes)
        {
            RefreshNodeList();
        }
    }

    /// <summary>
    /// Finds all GraphNode components in the scene and updates the list.
    /// </summary>
    public void RefreshNodeList()
    {
        allNodes = FindObjectsOfType<GraphNode>().ToList();

        // Auto-assign IDs if missing
        for (int i = 0; i < allNodes.Count; i++)
        {
            if (allNodes[i].nodeId == 0)
            {
                allNodes[i].nodeId = i + 1;
            }
        }

        Debug.Log($"GraphManager: Found {allNodes.Count} nodes");
    }

    /// <summary>
    /// Gets a node by its ID.
    /// </summary>
    public GraphNode GetNodeById(int nodeId)
    {
        return allNodes.FirstOrDefault(n => n.nodeId == nodeId);
    }

    /// <summary>
    /// Gets all nodes of a specific type.
    /// </summary>
    public List<GraphNode> GetNodesByType(GraphNode.NodeType type)
    {
        return allNodes.Where(n => n.nodeType == type).ToList();
    }

    /// <summary>
    /// Gets all nodes in a specific room.
    /// </summary>
    public List<GraphNode> GetNodesInRoom(string roomName)
    {
        return allNodes.Where(n => n.roomName == roomName).ToList();
    }

    /// <summary>
    /// Exports the graph structure as JSON for the Python backend.
    /// </summary>
    public string ExportGraphToJson()
    {
        var graphData = new
        {
            nodes = allNodes.Select(n => new
            {
                id = n.nodeId,
                position = new { x = n.transform.position.x, y = n.transform.position.y, z = n.transform.position.z },
                type = n.nodeType.ToString(),
                roomName = n.roomName,
                connections = n.connectedNodes?.Where(cn => cn != null).Select(cn => cn.nodeId).ToArray() ?? new int[0]
            }).ToArray()
        };

        return JsonUtility.ToJson(graphData, true);
    }
}
