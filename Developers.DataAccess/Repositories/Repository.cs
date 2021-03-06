﻿using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Developers.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public Repository(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IEnumerable<T> ReadAll()
        {
            try
            {
                return JsonConvert.DeserializeObject<IEnumerable<T>>(File.ReadAllText(Path.Combine(_hostingEnvironment.ContentRootPath, $"{typeof(T).GetCustomAttributes(typeof(TableAttribute), true).Cast<TableAttribute>().Select(a => a.Name).FirstOrDefault()}.json")));
            }
            catch
            {
                // The business layer will catch the exception and map it to a custom one before throwing it to the service layer
                throw; 
            }
        }

        public async Task<IEnumerable<T>> ReadAllAsync()
        {
            return await Task.Run(() => ReadAll());
        }
    }
}