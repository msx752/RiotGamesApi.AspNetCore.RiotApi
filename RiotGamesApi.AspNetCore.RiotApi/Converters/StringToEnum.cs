﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotGamesApi.AspNetCore.RiotApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RiotGamesApi.AspNetCore.RiotApi.Converters
{
    public class StringToEnum<TEnum> : JsonConverter where TEnum : new()
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(string).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            TEnum enumVal = (TEnum)Enum.Parse(typeof(TEnum), reader.Value.ToSafetyString());
            if (enumVal == null)
                throw new Exception($"type of {typeof(TEnum).Name} doesn't contain such '{reader.Value}' value");
            return enumVal;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToSafetyString());
        }
    }
}