﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace ArisenStudio.Models.GameData.PS3
{
    [XmlRoot(ElementName = "package")]
    public class Package
    {
        [XmlAttribute(AttributeName = "version")] public string Version { get; set; }

        [XmlAttribute(AttributeName = "size")] public string Size { get; set; }

        [XmlAttribute(AttributeName = "sha1sum")] public string Sha1Sum { get; set; }

        [XmlAttribute(AttributeName = "url")] public string Url { get; set; }

        [XmlAttribute(AttributeName = "ps3_system_ver")] public string Ps3SystemVer { get; set; }

        [XmlElement(ElementName = "paramsfo")] public Paramsfo Paramsfo { get; set; }
    }

    [XmlRoot(ElementName = "paramsfo")]
    public class Paramsfo
    {
        [XmlElement(ElementName = "TITLE")] public string Title { get; set; }
    }

    [XmlRoot(ElementName = "tag")]
    public class Tag
    {
        [XmlElement(ElementName = "package")] public List<Package> Package { get; set; }

        [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

        [XmlAttribute(AttributeName = "popup")] public string Popup { get; set; }

        [XmlAttribute(AttributeName = "signoff")] public string Signoff { get; set; }
    }

    [XmlRoot(ElementName = "titlepatch")]
    public class TitlePatch
    {
        [XmlElement(ElementName = "tag")] public Tag Tag { get; set; }

        [XmlAttribute(AttributeName = "status")] public string Status { get; set; }

        [XmlAttribute(AttributeName = "titleid")] public string Titleid { get; set; }
    }
}