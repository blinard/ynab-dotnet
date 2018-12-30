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
  public class TransactionsWrapper {
    /// <summary>
    /// Gets or Sets Transactions
    /// </summary>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<TransactionDetail> Transactions { get; set; }

    /// <summary>
    /// The knowledge of the server
    /// </summary>
    /// <value>The knowledge of the server</value>
    [DataMember(Name="server_knowledge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "server_knowledge")]
    public int? ServerKnowledge { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionsWrapper {\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
