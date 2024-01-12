class Messages
{
    string[] colors = {
        "Black",
        "DarkBlue",
        "DarkGreen",
        "DarkCyan",
        "DarkRed",
        "DarkMagenta",
        "DarkYellow",
        "Gray",
        "DarkGray",
        "Blue",
        "Green",
        "Cyan",
        "Red",
        "Magenta",
        "Yellow",
        "White"
    };
    public void welcomeMessage() {
        
        Console.WriteLine(@" __          __  _                            _          _______        _        _____ _      _____   _ ");
        Console.WriteLine(@" \ \        / / | |                          | |        |__   __|      | |      / ____| |    |_   _| | |");
        Console.WriteLine(@"  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___      | | ___   __| | ___ | |    | |      | |   | |");
        Console.WriteLine(@"   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \     | |/ _ \ / _` |/ _ \| |    | |      | |   | |");
        Console.WriteLine(@"    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |    | | (_) | (_| | (_) | |____| |____ _| |_  |_|");
        Console.WriteLine(@"     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/     |_|\___/ \__,_|\___/ \_____|______|_____| (_)");
        Console.WriteLine(@"                                                                                                        ");
        Console.WriteLine(@"                                                                                                        ");
    }

    public void initMessage() {
        Console.WriteLine("enter 'help' or 'h' to see available commands");
    }

    public void exitMessage() {
        Console.WriteLine("Bye!");
    }

    public void displayCommands() {
        Console.WriteLine("Available commands:");
        Console.WriteLine();

        Console.WriteLine("new (n) \"[description]\" [priority] [color]");
        Console.WriteLine("\tcreates a new todo\n");

        Console.WriteLine("remove (r) [todo id]");
        Console.WriteLine("\tremoves todo\n");

        Console.WriteLine("mark (m) [todo id] [done/undone]");
        Console.WriteLine("\tchanges todo status\n");
        // Might add mark (m) all [done/undone]
        // Marks all done/undone

        Console.WriteLine("clean (c)");
        Console.WriteLine("\tdeletes all todods marked 'done'\n");

        Console.WriteLine("edit (e) [todo id] \"[description/priority/color]\" \"[the change]\"");
        Console.WriteLine("\tchange todo\n");

        // undo (u)
        // undo last action

        Console.WriteLine("show (s)");
        Console.WriteLine("\tshow all todos\n");

        Console.WriteLine("help (h)");
        Console.WriteLine("\tshow available commands\n");

        Console.WriteLine("quit (q)");
        Console.WriteLine("\texit TodoCLI\n");

        Console.WriteLine("Available colors:");
        foreach (string color in colors) {
            Console.Write(color + " ");
        }
        Console.WriteLine();
    }   
}