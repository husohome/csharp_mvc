﻿
public class BSite
{
    public string sno { get; set; }
    public string sna { get; set; }
    public string tot { get; set; }
    public string sbi { get; set; }
    public string sarea { get; set; }
    public string mday { get; set; }
    public string lat { get; set; }
    public string lng { get; set; }
    public string ar { get; set; }
    public string sareaen { get; set; }
    public string snaen { get; set; }
    public string aren { get; set; }
    public string bemp { get; set; }
    public string act { get; set; }

    public override string ToString()
    {
        return $"{this.sno} {this.sna} {this.tot} {this.sbi} {this.sarea} {this.mday}";
    }
}
