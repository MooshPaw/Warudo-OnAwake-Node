# Warudo-OnAwake-Node
Adds an "On Awake" node to trigger a flow ONCE after the scene loads

# Installation
Subscribe to the [Steam Workshop Item](https://steamcommunity.com/sharedfiles/filedetails/?id=3810208986)
# Manual Installation
Download the OnAwakeNode.cs on your Warudo\Warudo_Data\StreamingAssets\Playground folder

# How does it work?
Unfortunately this isn't a real "Awake()", but rather an OnUpdate that has a check to only trigger a flow a single time after the scene loads.

This is technically better as the regular "On Update" node would constantly trigger the entire node flow, if it's too big, it could get a bit laggy. Instead, this node would limit itself to constantly check if its internal variable is true or false before firing the exit flow.

Ideally I would've used ["OnAllNodesDeserialized()"](https://docs.warudo.app/docs/scripting/api/nodes#lifecycle) but I couldn't get it to trigger the exit flow, so I got this method instead
