namespace SharedUtilities
{
    public class InputFileMethods
    {
        public const string InputFileName = "input";
        public static string ReadInputFile()
        {
            return File.ReadAllText(GetInputFilePath());
        }

        public static string GetProjectRootDirectory()
        {
            string currentWorkingDirectory = Environment.CurrentDirectory;
            return Directory.GetParent(currentWorkingDirectory).Parent.Parent.FullName;
        }

        public static string GetInputFilePath()
        {
            return Path.Join(GetProjectRootDirectory(), InputFileName);
        }
    }
}
