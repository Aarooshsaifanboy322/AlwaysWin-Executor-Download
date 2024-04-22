// Window properties
Window.BackgroundColor = Colors.Black;
Window.TextColor = Colors.White;
Window.BorderRadius = 14;

// Write code area
WriteCodeArea.Font = Font.Monospace;
WriteCodeArea.ShowLineCount = true;

// List properties
List.Header = "View Scripts";
List.ScriptItems = GetRobloxScripts();
List.Border = BorderColor.White;

// Attach button
Button AttachButton = new Button();
AttachButton.Text = "Attach";
AttachButton.Color = Colors.Green;
AttachButton.TextColor = Colors.White;
AttachButton.BorderRadius = 7;

// Execute Code button
Button ExecuteCodeButton = new Button();
ExecuteCodeButton.Text = "Execute Code";
ExecuteCodeButton.Color = Colors.Green;
ExecuteCodeButton.TextColor = Colors.White;
ExecuteCodeButton.BorderRadius = 7;

// Attach Executor to Roblox
AttachButton.Click += AttachExecutorToRoblox;

// Execute scripts in Roblox
ExecuteCodeButton.Click += ExecuteScriptsInRoblox;
