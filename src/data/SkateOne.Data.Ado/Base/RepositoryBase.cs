﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Common.Data.Base;
using SkateOne.Domain;

namespace SkateOne.Data.Ado.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        private readonly SqlConnection connection;

        private Dictionary<Type, string> sqlDictionary;

        public RepositoryBase(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            SetDictionary();
        }

        private void SetDictionary()
        {
            sqlDictionary = new Dictionary<Type, string>
            {
                {typeof(Skater), "SELECT TOP 1000 Id, Name, Brand, Stance FROM Skate.Skater"}
            };
        }

        public IEnumerable<T> GetAll()
        {
            var sqlText = sqlDictionary[typeof(T)];

            var result = new List<T>();
            using (connection)
            {
                var cmd = new SqlCommand(sqlText, connection);
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var item = Map(reader);
                    result.Add(item);
                }
            }
            return result;
        }

        private static T Map(IDataRecord record)
        {
            var item = Activator.CreateInstance<T>();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!record.IsDBNull(record.GetOrdinal(property.Name)))
                    property.SetValue(item, record[property.Name]);
            }
            return item;
        }  
    }
}
