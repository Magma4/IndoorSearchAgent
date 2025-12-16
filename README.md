# Indoor Search Agent

An indoor navigation system concept that pairs a Unity Universal Render Pipeline (URP) client with a Python inference backend. Pathfinding blends classic A* with reinforcement learning to pick efficient indoor routes. Target performance: search 10,000+ graph nodes in under 50ms.

## What it does (goal)
- Visualize indoor spaces in Unity URP with clickable points of interest and routes.
- Request routes from a Python inference service that runs A* and RL-based policies.
- Stream updated paths to the Unity client for smooth camera/agent motion.
- Collect telemetry to tune heuristics and learning policies over time.

## Project layout
- `model/` — Unity project root containing assets, models, and scenes.
- `model/Assets/Scenes/PrimaryScene.unity` — primary scene under construction.
- Generated folders to ignore: `Library/`, `Temp/`, `Logs/` (Unity output).

## Getting started (current state)
1) Open Unity (check `ProjectSettings` for the exact version).
2) Open the `model` folder as the Unity project root.
3) Work in `Assets/Scenes/PrimaryScene.unity` for visuals and interaction.
