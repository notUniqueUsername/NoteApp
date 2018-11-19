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
    public static class ProjectManager
    {
        const string _file = @"C:\Users\User\Desktop\NoteApp.notes";

        public static void SaveToFile(Project data)
        {
            using (StreamWriter file = File.CreateText(_file))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public static Project LoadFromFile()
        {
            using (StreamReader file = File.OpenText(_file))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (Project)serializer.Deserialize(file, typeof(Project));
            }
        }
    }
}
