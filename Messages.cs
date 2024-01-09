class Messages
{
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

    public void exitMessage() {
        Console.WriteLine("Bye!");
    }

    public void displayCommands() {
        Console.WriteLine("Available commands:");
        Console.WriteLine();

        Console.WriteLine("new (n) [what to do] [priority] [color]");
        Console.WriteLine("\tcreates a new todo\n");

        Console.WriteLine("remove (r) [todo id]");
        Console.WriteLine("\tremoves todo\n");

        Console.WriteLine("mark (m) [todo id] [done/undone]");
        Console.WriteLine("\tchanges todo status\n");

        Console.WriteLine("clean (c)");
        Console.WriteLine("\tdeletes all todods marked 'done'\n");

        Console.WriteLine("edit (e) [todo id]");
        Console.WriteLine("\tchange todo\n");

        Console.WriteLine("show (s)");
        Console.WriteLine("\tshow all todos\n");

        Console.WriteLine("quit (q)");
        Console.WriteLine("\texit TodoCLI\n");
    }
}