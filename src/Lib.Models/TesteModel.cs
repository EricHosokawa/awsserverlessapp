﻿using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lib.Models
{
    [DynamoDBTable("teste_dynamodb")]
    public class TesteModel
    {
        public string Id { get; set; }

        public string Texto { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}