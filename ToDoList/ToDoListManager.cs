using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class TodoListManager
{
	private string filePath = "todoList.json";
	private List<string> tasks = new List<string>();

	public void Run()
	{
		LoadTasks();
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Todo List Manager");
			Console.WriteLine("1. Visa uppgifter");
			Console.WriteLine("2. Lägg till uppgift");
			Console.WriteLine("3. Ta bort uppgift");
			Console.WriteLine("4. Avsluta");
			Console.Write("Välj ett alternativ: ");

			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					ShowTasks();
					break;
				case "2":
					AddTask();
					break;
				case "3":
					RemoveTask();
					break;
				case "4":
					SaveTasks();
					return;
				default:
					Console.WriteLine("Ogiltigt val!");
					break;
			}
		}
	}

	private void ShowTasks()
	{
		Console.Clear();
		Console.WriteLine("Dina uppgifter:");
		if (tasks.Count == 0)
		{
			Console.WriteLine("Inga uppgifter att visa.");
		}
		else
		{
			for (int i = 0; i < tasks.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {tasks[i]}");
			}
		}
		Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
		Console.ReadKey();
	}

	private void AddTask()
	{
		Console.Clear();
		Console.Write("Ange en ny uppgift: ");
		string task = Console.ReadLine();
		if (!string.IsNullOrWhiteSpace(task))
		{
			tasks.Add(task);
			Console.WriteLine("Uppgift tillagd!");
		}
		else
		{
			Console.WriteLine("Uppgiften kan inte vara tom!");
		}
		System.Threading.Thread.Sleep(1000);
	}

	private void RemoveTask()
	{
		ShowTasks();
		Console.Write("Ange numret på uppgiften att ta bort: ");
		if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
		{
			tasks.RemoveAt(index - 1);
			Console.WriteLine("Uppgift borttagen!");
		}
		else
		{
			Console.WriteLine("Ogiltigt nummer!");
		}
		System.Threading.Thread.Sleep(1000);
	}

	private void LoadTasks()
	{
		if (File.Exists(filePath))
		{
			string json = File.ReadAllText(filePath);
			tasks = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
		}
	}

	private void SaveTasks()
	{
		string json = JsonSerializer.Serialize(tasks);
		File.WriteAllText(filePath, json);
	}
}
