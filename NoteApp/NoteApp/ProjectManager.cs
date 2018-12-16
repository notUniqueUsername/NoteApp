using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс для сериализации и дессириализации
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Запись в фаил
        /// </summary>
        /// <param name="data">
        /// Список записываемых заметок
        /// </param>
        public static void SaveToFile(Project data, string filePath = "Standart")
        {
            if (filePath == "Standart")
            {
                filePath = Environment.CurrentDirectory.ToString()+ @"\NoteApp.notes";
            }
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        /// <summary>
        /// Чтение из фаила
        /// </summary>
        /// <returns>
        /// Список заметок
        /// </returns>
        public static Project LoadFromFile(string filePath = "Standart")
        {
            if (filePath == "Standart")
            {
                filePath = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"NoteApp.notes";
            }
            try
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (Project)serializer.Deserialize(file, typeof(Project));
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                var project = new Project();
                ProjectManager.SaveToFile(project,filePath);
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (Project)serializer.Deserialize(file, typeof(Project));
                }
            }
        }
    }
}
