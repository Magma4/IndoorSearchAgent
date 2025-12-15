## Indoor Search Agent

Indoor Search Agent is a Unity prototype that explores indoor navigation and search mechanics inside a Universal Render Pipeline (URP) scene. The repository currently contains the Unity project (`IndoorSearchAgent/IndoorSearchAgent/My project`) configured with URP assets, basic materials, and starter scenes you can build on top of.

### Project snapshot
- **Unity version**: `2021.3.45f2` (`ProjectSettings/ProjectVersion.txt`)
- **Rendering pipeline**: Universal Render Pipeline presets under `Assets/Settings/`
- **Primary scene**: `Assets/Scenes/MainScene.unity` (plus the default `SampleScene`)
- **Key assets**: Plan material/screenshot references plus the default URP tutorial content

### Repository layout
- `IndoorSearchAgent/IndoorSearchAgent/My project/Assets/` — All game-ready assets, materials, scenes, and URP settings.
- `IndoorSearchAgent/IndoorSearchAgent/My project/Packages/` — Unity package manifest and lock file that capture package dependencies (IDE integrations, URP, TextMeshPro, ProBuilder, etc.).
- `IndoorSearchAgent/IndoorSearchAgent/My project/ProjectSettings/` — Unity project configuration (player, quality, graphics, input, XR).
- `IndoorSearchAgent/IndoorSearchAgent/My project/Logs/` — Unity editor logs (optional, can be deleted when sharing).
- `My project (1)/` — Spare copy of the Unity project as originally exported; keep or remove as needed.

### Getting started
1. **Install Unity 2021.3 LTS** (the exact revision listed above) via Unity Hub.
2. **Clone this repo** or pull the latest changes:
   ```bash
   git clone https://github.com/Magma4/IndoorSearchAgent.git
   ```
3. **Open Unity Hub → Add project from disk** and point it at `IndoorSearchAgent/IndoorSearchAgent/My project`.
4. **Select `MainScene`** (Assets → Scenes) and press Play in the editor to explore the prototype.

### Building
1. Open `File → Build Settings…`.
2. Add `MainScene` (if it is not already in the Scenes In Build list).
3. Choose your target platform (tested on Standalone).
4. Click **Build** (or **Build & Run**) and select an output directory.

### Recommended ignores
Unity generates very large cache folders that should not be versioned (`Library/`, `Logs/`, `Temp/`, `Obj/`, `Build/`, `UserSettings/`, etc.). If you have not already done so, add a Unity `.gitignore` (see the official template from GitHub) before committing new work. Keeping those folders out of version control will dramatically reduce repository size and avoid merge noise.

### Contributing / next steps
- Sketch out the indoor environment in `MainScene` using ProBuilder or imported meshes.
- Layer in navigation/search logic (e.g., NavMesh agents, AI behaviors, or sensor simulations).
- When making visual changes, capture refreshed screenshots in `Assets/` for quick documentation.
- Use branches + pull requests for larger features before merging into `main`.

Feel free to extend this README with gameplay notes, diagrams, or onboarding tips as the project evolves.

