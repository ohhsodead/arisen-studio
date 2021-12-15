using ModioX.Extensions;
using Newtonsoft.Json;
using System;

namespace ModioX.Database
{
    /// <summary>
    /// Get Package Information.
    /// </summary>
    public class PackageItemData
    {
        public string Category { get; set; }

        public string TitleId { get; set; }

        public string Region { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Rap { get; set; }

        public string ContentId { get; set; }

        public string ModifiedDate { get; set; }

        public string DownloadRap { get; set; }

        public string Size { get; set; }

        public string Sha256 { get; set; }

        public string InstallFilePathPKG => $"/dev_hdd0/packages/{Name.RemoveInvalidChars()}.pkg";

        public string InstallFilePathRAP => $"/dev_hdd0/exdata/{ContentId.RemoveInvalidChars()}.rap";

        public bool IsNameMissing => Name.IsNullOrEmpty();

        public bool IsUrlMissing => Url.IsNullOrEmpty();

        public bool IsRapRequired => !Rap.Equals("NOT REQUIRED");

        public bool IsRapMissing => Rap.Equals("MISSING") | Rap.IsNullOrEmpty();

        public bool IsDateMissing => ModifiedDate.IsNullOrEmpty();

        public bool IsSizeMissing => Size.IsNullOrEmpty();

        public bool IsSha256Missing => Sha256.IsNullOrEmpty();

        public string GetRapUrl => $"https://nopaystation.com/tools/rap2file/{ContentId}/{Rap}";
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(long) || t == typeof(long?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            string value = serializer.Deserialize<string>(reader);

            if (long.TryParse(value, out long l))
            {
                return l;
            }

            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            long value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new();
    }
}