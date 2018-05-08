using System.Collections.Generic;
using System.Xml.Serialization;

namespace Duy.FootballData.App
{
    [XmlRoot("tbody")]
    public class TBODY
    {
        [XmlElement("tr")]
        public List<TR> TRs { get; set; }
    }

    public class TR
    {
        [XmlElement("td")]
        public List<TD> TDs { get; set; }
    }

    public class TD
    {
        [XmlElement("p")]
        public string P { get; set; }
    }
}
