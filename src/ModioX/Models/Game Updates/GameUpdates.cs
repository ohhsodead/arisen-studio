using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace ModioX.Models.Game_Updates
{
    [XmlRoot(ElementName = "package")]
	public partial class Package
	{
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
		[XmlAttribute(AttributeName = "sha1sum")]
		public string Sha1sum { get; set; }
		[XmlAttribute(AttributeName = "url")]
		public string Url { get; set; }
		[XmlAttribute(AttributeName = "ps3_system_ver")]
		public string Ps3_system_ver { get; set; }
		[XmlElement(ElementName = "paramsfo")]
		public Paramsfo Paramsfo { get; set; }
	}

	[XmlRoot(ElementName = "paramsfo")]
	public partial class Paramsfo
	{
		[XmlElement(ElementName = "TITLE")]
		public string TITLE { get; set; }
	}

	[XmlRoot(ElementName = "tag")]
	public partial class Tag
	{
		[XmlElement(ElementName = "package")]
		public List<Package> Package { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "popup")]
		public string Popup { get; set; }
		[XmlAttribute(AttributeName = "signoff")]
		public string Signoff { get; set; }
	}

	[XmlRoot(ElementName = "titlepatch")]
	public partial class Titlepatch
	{
		[XmlElement(ElementName = "tag")]
		public Tag Tag { get; set; }
		[XmlAttribute(AttributeName = "status")]
		public string Status { get; set; }
		[XmlAttribute(AttributeName = "titleid")]
		public string Titleid { get; set; }
	}
}