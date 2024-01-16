# TodoCLI

Terminal based Todolist made entirely in C# .NET

## Version
Last runned on .NET - 8.0.100

### Available commands

| Command Syntax | Description                                          |
|----------------|------------------------------------------------------|
| new (n) "[description]" [priority] [color] | Creates a new todo                                   |
| remove (r) [todo id] | Removes a todo                                       |
| mark (m) [todo id] [done/undone] | Changes the status of a todo                         |
| clean (c) | Deletes all todos marked as 'done'                    |
| edit (e) [todo id] "[description/priority/color]" "[the change]" | Changes the description, priority or color of a todo |
| show (s) | Displays all todos                                  |
| help (h) | Displays the available commands                      |
| quit (q) | Exits the TodoCLI                                    |

### Available colors to todos:
Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White

> colors must be written exact