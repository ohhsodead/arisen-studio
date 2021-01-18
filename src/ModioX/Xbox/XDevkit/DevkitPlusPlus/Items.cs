namespace XDevkit
{
    public class Items
    {
        public string Class;
        public string DefaultV;
        public string Description;
        public string Name;
        public string Offset;
        public string RecommendedV;

        public Items(string Item_class, string offset, string name, string DValue, string RValue, string description)
        {
            Class = Item_class;
            Offset = offset;
            Name = name;
            DefaultV = DValue;
            RecommendedV = RValue;
            Description = description;
        }

        public override string ToString() =>
            $"Class = {Class} Offset = {Offset} Name = {Name} Default_Value = {DefaultV} Recommended_Value = {RecommendedV} Description = {Description}";
    }

    public class SearchResults
    {
        public string ID { get; set; }
        public string Offset { get; set; }
        public string Value { get; set; }
    }

    public class Trainers
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string TitleID { get; set; }
        public CodeList CodeList { get; set; }
    }

    public class CodeList
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public uint Address { get; set; }
        public uint Code { get; set; }
    }
}

