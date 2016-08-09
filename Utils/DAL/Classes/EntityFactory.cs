using System;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;

namespace DAL.Classes
{
    internal static class EntityFactory
    {
        internal static T getEntity<T>(Object model, Object entity)
        {
            var modelProperties = entity.GetType().GetProperties();
            foreach (var prop in model.GetType().GetProperties())
            {
                var thisProp = modelProperties.FirstOrDefault(n => n.Name == prop.Name && n.PropertyType == prop.PropertyType);
                if (thisProp != null)
                {
                    var value = prop.GetValue(model, null);
                    thisProp.SetValue(entity, value, null);
                }
            }
            return (T)entity;
        }               
    }
}