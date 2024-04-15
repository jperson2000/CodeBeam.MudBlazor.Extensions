using Microsoft.AspNetCore.Components;
using System.Text.Json.Nodes;

namespace MudExtensions;

/// <summary>
/// Represents a tree view which displays a snippet of JSON.
/// </summary>
public partial class MudJsonTreeView : ComponentBase
{
    /// <summary>
    /// Gets or sets the JSON to be displayed.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public string Json { get; set; }

    /// <summary>
    /// Gets or sets the root node of the JSON to display.
    /// </summary>
    public JsonNode Root { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the tree contents are compacted.
    /// </summary>
    [Parameter]
    public bool Dense { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the current row is highlighted.
    /// </summary>
    [Parameter]
    public bool Hover { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether items are sorted by key.
    /// </summary>
    [Parameter]
    public bool Sorted { get; set; }

    /// <inheritdoc />
    protected override void OnInitialized()
    {
        Root = JsonNode.Parse(Json);
    }
}
