using Godot;

namespace AutoBattler.Utils
{
    public partial class SceneLoader : Node
    {
        [Export]
        public PackedScene TargetScene { get; set; }

        [Export]
        public string ScenePath { get; set; } = "";

        [Export]
        public bool UseScenePath { get; set; } = false;

        public void LoadTargetScene()
        {
            if (UseScenePath && !string.IsNullOrEmpty(ScenePath))
            {
                GameManager.Instance?.LoadScene(ScenePath);
            }
            else if (TargetScene != null)
            {
                var err = GetTree().ChangeSceneToPacked(TargetScene);
                if (err != Error.Ok)
                {
                    GD.PushError($"Failed to change scene: {err}");
                }
            }
            else
            {
                GD.PushError("SceneLoader: No scene specified");
            }
        }
    }
}
