﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Digipolis.Toolbox.DataAccess.EventHandler.Auditor;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Data.Entity.Core;

namespace Digipolis.Toolbox.DataAccess.EventHandler
{
    [Serializable]
    public class AuditLog
    {
        public AuditLog()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime Created { get; set; }
        public string EntityFullName { get; set; }
        public Object Entity { get; set; }
        public EntityKey EntityId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string PropertyName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AuditType Operation { get; set; }
    }
}