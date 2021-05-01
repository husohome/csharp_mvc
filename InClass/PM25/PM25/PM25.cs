
namespace PM25 {
    public class PM25
    {
        public bool include_total { get; set; }
        public string resource_id { get; set; }
        public Field[] fields { get; set; }
        public __Extras __extras { get; set; }
        public string records_format { get; set; }
        public Record[] records { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public _Links _links { get; set; }
        public int total { get; set; }
    }

    public class __Extras
    {
        public string api_key { get; set; }
    }

    public class _Links
    {
        public string start { get; set; }
        public string next { get; set; }
    }

    public class Field
    {
        public Info info { get; set; }
        public string type { get; set; }
        public string id { get; set; }
    }

    public class Info
    {
        public string notes { get; set; }
        public string label { get; set; }
    }

    public class Record
    {
        public string Site { get; set; }
        public string county { get; set; }
        public string PM25 { get; set; }
        public string DataCreationDate { get; set; }
        public string ItemUnit { get; set; }

        public override string ToString()
        {
            return $"{this.Site} {this.county} {this.PM25} {this.DataCreationDate} {this.ItemUnit}";
        }
    }

}
