﻿namespace SoftwareCompany.Web.Models
{

    //class StringJsonConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType)
    //    {
    //        // this converter can handle converting some JSON to a List<string>
    //        return true; // objectType == typeof(string);
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
    //        JsonSerializer serializer)
    //    {
    //        // Convert an object to a flat list of strings containing
    //        // just the property names from the object.
    //        JObject obj = JObject.Load(reader);
    //        return string.Join(",", obj.Properties().Select(p => p.Name).ToList());
    //    }

    //    public override bool CanWrite
    //    {
    //        get { return false; }
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}