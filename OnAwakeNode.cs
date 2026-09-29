using Warudo.Core.Attributes;
using Warudo.Core.Graphs;

[NodeType(
    Id = "66796054-d432-4ee6-a930-1d6da599c1a3", // Must be unique. Generate one at https://guidgenerator.com/
    Title = "On Awake",
    Category = "CATEGORY_EVENTS")]
public class OnAwakeNode : Node
{
    [FlowOutput]
    public Continuation Exit;

    private bool fired;

    public override void OnUpdate() {
        base.OnUpdate();
        if (fired) return;
        fired = true;
        InvokeFlow(nameof(Exit));
    }
}
