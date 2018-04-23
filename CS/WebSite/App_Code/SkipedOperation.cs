using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SkipedOperation
/// </summary>
public class SkipedOperation {
    private List<int> skippedDetailBands;

    public List<int> SkippedDetailBands {
        get {
            if(HttpContext.Current.Session["SkipedList"] == null) {
                HttpContext.Current.Session["SkipedList"] = new List<int>();
            }
            return HttpContext.Current.Session["SkipedList"] as List<int>;
        }
        set { skippedDetailBands = value; }
    }

    public void UpdateDetail(int detailID) {
        if(SkippedDetailBands.Contains(detailID))
            SkippedDetailBands.Remove(detailID);
        else
            SkippedDetailBands.Add(detailID);
    }
}