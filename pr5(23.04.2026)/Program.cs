namespace pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(folderPath); 
            string fileName = "экзампле.тхт";
            string fullPath = Path.Combine(folderPath, "Folder", fileName);

            File.Create(fullPath).Close();
            File.WriteAllText(fullPath, "здарова");
            File.AppendAllText(fullPath, " корёва");
            File.WriteAllText(fullPath, "здарова-здарова" + Environment.NewLine); 
            string[] words = new string[] { "ура", "клево", "очень" };
            File.WriteAllLines(fullPath, words);
            File.AppendAllLines(fullPath, words);
            File.AppendAllText(fullPath, "текст");

            string content = File.ReadAllText(fullPath);
            string[] lines = File.ReadAllLines(fullPath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            string folderPath2 = Path.Combine(folderPath, "ЭкзамплеФолдер");
            string filePath = Path.Combine(folderPath2, "исёЭкзампле");
            if (!Directory.Exists(folderPath2))
            {
                Directory.CreateDirectory(folderPath2);
            }
            Directory.CreateDirectory(folderPath2);
            File.Create(filePath).Close();
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            else
            {
                File.WriteAllText(filePath, "");
            }
            string folderPath3 = Path.GetDirectoryName(filePath);
            string fileName2 = Path.GetFileName(filePath);

        }
    }
}