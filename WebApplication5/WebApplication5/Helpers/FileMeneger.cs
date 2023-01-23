//namespace WebApplication5.Helpers
//{
//    public class FileMeneger
//    {
//        public static string SaveFile(string rootPath,string folderName,IFormFile file)
//        {
//            string name = file.FileName;
//            name = name.Length>64 ? name.Substring(name.Length-64,64) : name;
//            name = Guid.NewGuid().ToString() + name;
//            string savepath = Path.Combine(rootPath,folderName,name);
//            using(FileStream fileStream = new FileStream(savepath,FileMode.Create))
//            {
//                file.CopyTo(fileStream);
//            }
//            return name;
//        }
//    }
//}
