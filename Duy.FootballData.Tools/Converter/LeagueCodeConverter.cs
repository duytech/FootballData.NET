using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Duy.FootballData.App.Tools
{
    public class LeagueCodeConverter
    {
        public string ReadLeagueCodeTable(string xmlFilePath)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
            var builder = new StringBuilder();

            var serializer = new XmlSerializer(typeof(TBODY));
            using (var reader = new StringReader(xmlDoc.InnerXml))
            {
                var tbody = (TBODY)serializer.Deserialize(reader);
                for (var index = 0; index < tbody.TRs.Count; index++)
                {
                    // Remove table head
                    if (index == 0)
                        continue;

                    builder.AppendLine("/// <summary>");
                    builder.AppendLine($"/// {tbody.TRs[index].TDs[1].P} {tbody.TRs[index].TDs[2].P}");
                    builder.AppendLine("/// </summary>");
                    builder.Append($"{tbody.TRs[index].TDs[0].P}");

                    if (index < tbody.TRs.Count - 1)
                        builder.AppendLine(",");
                }
            }

            return builder.ToString();
        }
    }
}
