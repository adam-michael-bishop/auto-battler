using System;
using AutoBattler.Entities;
using AutoBattler.UI;
using Godot;

namespace AutoBattler
{
    public partial class GameManager : Node
    {
        public static GameManager Instance { get; private set; }

        public string CurrentScenePath => GetTree()?.CurrentScene?.SceneFilePath ?? string.Empty;

        public void LoadScene(String sceneName)
        {
            var scenePath = GetScenePathFromName(sceneName);

            if (!ResourceLoader.Exists(scenePath))
            {
                GD.PushError($"Scene not found: {scenePath}");
                return;
            }

            var err = GetTree().ChangeSceneToFile(scenePath);
            if (err != Error.Ok)
            {
                GD.PushError($"Failed to change scene to {scenePath}: {err}");
                return;
            }
        }

        private string GetScenePathFromName(String sceneName)
        {
            if (string.IsNullOrWhiteSpace(sceneName))
            {
                return "res://Scenes/main_scene.tscn";
            }

            var path = sceneName.Trim().Replace('\\', '/');

            if (!path.EndsWith(".tscn", StringComparison.OrdinalIgnoreCase))
            {
                path += ".tscn";
            }

            if (path.StartsWith("res://", StringComparison.OrdinalIgnoreCase))
            {
                return path;
            }

            while (path.StartsWith("./", StringComparison.Ordinal))
            {
                path = path.Substring(2);
            }
            while (path.StartsWith("/", StringComparison.Ordinal))
            {
                path = path.Substring(1);
            }

            if (path.StartsWith("Scenes/", StringComparison.OrdinalIgnoreCase))
            {
                path = path.Substring("Scenes/".Length);
            }

            return $"res://Scenes/{path}";
        }

        public override void _Process(double delta) { }

        public override void _Ready()
        {
            Instance = this;
        }
    }
}
