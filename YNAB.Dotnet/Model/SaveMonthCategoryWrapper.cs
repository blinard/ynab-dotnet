using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace YNAB.Dotnet.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SaveMonthCategoryWrapper {
    /// <summary>
    /// Gets or Sets MonthCategory
    /// </summary>
    [DataMember(Name="month_category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month_category")]
    public SaveMonthCategory MonthCategory { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaveMonthCategoryWrapper {\n");
      sb.Append("  MonthCategory: ").Append(MonthCategory).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
