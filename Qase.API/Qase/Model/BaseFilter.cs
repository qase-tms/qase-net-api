using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model
{
  public class BaseFilter
  {
    public BaseFilter()
    {
      limit = 0;
      offset = 0;
      DictionaryFilters = new Dictionary<string, object>();
    }
    public int limit { get; set; }
    public int offset { get; set; }
    public Dictionary<string, object> DictionaryFilters { get; set; }
  }
}
