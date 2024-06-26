﻿using System;
using System.CommandLine;

namespace Todo.CLI.Commands;

public class TodoCommand : RootCommand
{
    private static readonly Option<bool> Version = new(["-v", "--version"], "Prints out the todo CLI version.");
    public TodoCommand(IServiceProvider serviceProvider)
    {
        // Add static parameters
        Description = "A CLI to manage Microsoft to do items.";

        // Add back when https://github.com/dotnet/command-line-api/issues/1691 is resolved.
        //// Add options
        //Add(Version);

        //// Add handlers
        //this.SetHandler(TodoCommandHandler.Create(), Version);

        // Add subcommands
        Add(new AddCommand(serviceProvider));
        Add(new ListCommand(serviceProvider));
        Add(new CompleteCommand(serviceProvider));
        Add(new RemoveCommand(serviceProvider));
        Add(new RemoveCompletedCommand(serviceProvider));
    }
}