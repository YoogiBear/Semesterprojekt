namespace cs.Data;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class AnswerLog
{
    public string Place { get; set; }
    public string Question { get; set; }
    public string PlayerAnswer { get; set; }
    public bool IsCorrect { get; set; }
}


public static class FileRepository
{
    private static readonly string Folderpath = Path.Combine("Data", "Json");
    public static void SaveToFile(string filename, AnswerLog data)
    {
        Directory.CreateDirectory(Folderpath);
        
        string path = Path.Combine(Folderpath, filename);
        
        List<AnswerLog> logList;
        
        if (File.Exists(path))
        {
            string existingJson = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(existingJson))
                logList = new List<AnswerLog>();
            else
                logList = JsonSerializer.Deserialize<List<AnswerLog>>(existingJson) ?? new List<AnswerLog>();
        }
        else
        {
            logList = new List<AnswerLog>();
        }
        
        logList.Add(data);
        
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonOutput = JsonSerializer.Serialize(logList, options);
        File.WriteAllText(path, jsonOutput);
    }
}


public static class GameSession
{
    private static string _currentUsername;
    
    public static void Login(string username)
    {
        _currentUsername = username;
    }
    
    public static void RecordAnswer(string place, string question, string answer, bool isCorrect)
    {
        if (string.IsNullOrEmpty(_currentUsername)) return;
        
        string filename = $"{_currentUsername}.json";
        
        var log = new AnswerLog
        {
            Place = place,
            Question = question,
            PlayerAnswer = answer,
            IsCorrect = isCorrect,
        };

        FileRepository.SaveToFile(filename, log);
    }
}