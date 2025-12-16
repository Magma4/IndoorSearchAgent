using UnityEngine;

/// <summary>
/// Represents a node in the navigation graph.
/// Can be placed at doors, room centers, or key waypoints.
/// </summary>
public class GraphNode : MonoBehaviour
{
    [Header("Node Properties")]
    [Tooltip("Unique identifier for this node")]
    public int nodeId;

    [Tooltip("Type of node: Room, Door, or Waypoint")]
    public NodeType nodeType = NodeType.Waypoint;

    [Tooltip("Room name or identifier (if this is a room or door)")]
    public string roomName = "";

    [Header("Connections")]
    [Tooltip("Other nodes this node is connected to (for pathfinding)")]
    public GraphNode[] connectedNodes;

    [Header("Visualization")]
    [Tooltip("Color for gizmo visualization")]
    public Color gizmoColor = Color.cyan;

    public enum NodeType
    {
        Room,
        Door,
        Waypoint
    }

    void OnDrawGizmos()
    {
        // Draw node as a sphere
        Gizmos.color = gizmoColor;
        Gizmos.DrawSphere(transform.position, 0.2f);

        // Draw connections to other nodes
        if (connectedNodes != null)
        {
            Gizmos.color = Color.yellow;
            foreach (var connectedNode in connectedNodes)
            {
                if (connectedNode != null)
                {
                    Gizmos.DrawLine(transform.position, connectedNode.transform.position);
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw a larger sphere when selected
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 0.3f);
    }
}
