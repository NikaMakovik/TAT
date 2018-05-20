using System.IO;
using Newtonsoft.Json;

namespace DEV_7
{
    class JSONSerializer
    {
        public void Serialize()
        {
            string path = @"D:\Workspace\TAT\DEV-7\DEV-7\storehouse.json";
            using (FileStream stream = new FileStream(path,
                FileMode.Open))
            {
            }
        }
        
    }
}
