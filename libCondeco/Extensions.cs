﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCondeco
{
    public static class Extensions
    {
        public static string ToJson(this object? obj, bool indent = false)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            if (!indent)
            {
                settings = new JsonSerializerSettings() { Formatting = Formatting.None };
            }

            var result = JsonConvert.SerializeObject(obj, settings);
            return result;
        }

        public static string ToJson<T>(this object obj, bool indent = false)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            if (!indent)
            {
                settings = new JsonSerializerSettings() { Formatting = Formatting.None };
            }

            var result = JsonConvert.SerializeObject((T)obj, settings);
            return result;
        }
    }
}
