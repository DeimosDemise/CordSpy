using System.Reflection;
using System.IO;
namespace CordSpy.Extract
{
    internal class Extraction
    {
        public static void Extract(string namespacee, string OutDirectory, string InternalFilepath, string resourcename)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            using (Stream s = assembly.GetManifestResourceStream(namespacee + "." + (InternalFilepath == "" ? "" : InternalFilepath + ".") + resourcename))
            using (BinaryReader br = new BinaryReader(s))
            using (FileStream ff = new FileStream(OutDirectory + "\\" + resourcename, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(ff))
                w.Write(br.ReadBytes((int)s.Length));
        }
    }
}
