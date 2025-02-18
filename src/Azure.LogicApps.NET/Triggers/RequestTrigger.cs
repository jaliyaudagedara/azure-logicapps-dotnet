﻿using Azure.LogicApps.NET.Base;
using System.Text.Json.Nodes;

namespace Azure.LogicApps.NET.Triggers;

public class RequestTrigger : WorkflowTriggerBase
{
	public new string Kind { get; } = "Http";

	public new string Type { get; } = "Request";

	public JsonObject Inputs { get; set; }
}
