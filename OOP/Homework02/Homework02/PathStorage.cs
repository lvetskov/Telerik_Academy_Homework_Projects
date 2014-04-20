using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework02
{
    static class PathStorage
    {
        public static void SavePath(Path temp)
        {
            using (StreamWriter writer = new StreamWriter(@"../../savedPaths.txt"))
            {
                foreach (var item in temp.Paths)
                {
                    writer.WriteLine(String.Format("({0}, {1}, {2})", item.X, item.Y, item.Z));
                    writer.Flush();
                }
            }
        }
        internal static Path LoadPath()
        {
            Path loadPath = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(@"../../savedPaths.txt"))
                {
                    while (reader.Peek() >= 0)
                    {
                        String line = reader.ReadLine();
                        String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File cannot be found! Try adding file.");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (OutOfMemoryException ome)
            {
                Console.WriteLine(ome.Message);
            }
            return loadPath;
        }
    }
}
